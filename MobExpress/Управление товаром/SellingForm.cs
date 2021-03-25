using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;

namespace MobExpress.Управление_товаром
{

    public partial class SellingForm : Form
    {
        public SellingForm(Int64 userId, MobExpressDataSet.ПользовательRow user)
        {
            this.InitializeComponent();

            this.SellerNamelbl.Text = user.Имя + " " + user.Фамилия;
        }

        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=MobExpress.mdb;Persist Security Info=True;User ID=admin");

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Функция выборки из БД
        /// </summary>
        private void Populate()
        {
            this.Con.Open();
            string query = "select ProdName,ProdQty from ProductTbl";
            var sda = new OleDbDataAdapter(query, this.Con);
            var builder = new OleDbCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            this.ProdoDGV.DataSource = ds.Tables[0];
            this.Con.Close();
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            this.Populate();
            this.PopulateBills();
            this.FileCombo();
        }

        /// <summary>
        /// Функция выборки из БД
        /// </summary>
        private void PopulateBills()
        {
            this.Con.Open();
            string query = "select * from BillTbl";
            var sda = new OleDbDataAdapter(query, this.Con);
            var builder = new OleDbCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            this.BillsDGV.DataSource = ds.Tables[0];
            this.Con.Close();
        }

        /// <summary>
        /// Отображение строк в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProdoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ProdoName.Text = this.ProdoDGV.SelectedRows[0].Cells[0].Value.ToString();
            this.ProdoPrice.Text = this.ProdoDGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        /// <summary>
        /// Выведение даты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            this.Datelbl.Text = DateTime.Today.Day.ToString() + "/" +
                DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        int Grdtotal = 0, n=0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.BillID.Text == "")
            {
                MessageBox.Show("Отсутсвует Id счёта","Информация",MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    this.Con.Open();
                    string query = "insert into BillTbl values("+ this.BillID.Text+"," +
                        "'"+ this.SellerNamelbl.Text+"','"+ this.Datelbl.Text+"'," +
                        ""+ this.Amtlbl.Text+")";
                    var cmd = new OleDbCommand(query, this.Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Заказ добавлен успешно!");
                    this.Con.Close();
                    this.PopulateBills();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("FILEMOBEXPRESS", new Font("Centure Gothic", 25,
                FontStyle.Bold),Brushes.Red,new Point(230));
            e.Graphics.DrawString("Bill ID:"+this.BillsDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Centure Gothic", 20,
                FontStyle.Bold), Brushes.Blue, new Point(100,70));
            e.Graphics.DrawString("Имя продавца:" + this.BillsDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Centure Gothic", 20,
                FontStyle.Bold), Brushes.Blue, new Point(100, 100));
            e.Graphics.DrawString("Дата:" + this.BillsDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Centure Gothic", 20,
                FontStyle.Bold), Brushes.Blue, new Point(100, 130));
            e.Graphics.DrawString("Общая сумма:" + this.BillsDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Centure Gothic", 20,
                FontStyle.Bold), Brushes.Blue, new Point(100, 160));
            e.Graphics.DrawString("Кодовое пространство", new Font("Centure Gothic", 20,
                FontStyle.Italic), Brushes.Red, new Point(270,230));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (this.printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                this.printDocument.Print();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Populate();
        }

        private void cbCategoryRefresh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Con.Open();
            string query = "select ProdName,ProdQty from ProductTbl where ProdCat='" + this.cbCategoryRefresh.SelectedValue.ToString() + "'";
            var sda = new OleDbDataAdapter(query, this.Con);
            var builder = new OleDbCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            this.ProdoDGV.DataSource = ds.Tables[0];
            this.Con.Close();
        }

        private void FileCombo()
        {
            //Этот метод свяжет поле со списком с базой данных
            this.Con.Open();
            var cmd = new OleDbCommand("Select CatName from CategoryTbl", this.Con);
            OleDbDataReader rdr;
            rdr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(rdr);
            this.cbCategoryRefresh.ValueMember = "catName";
            this.cbCategoryRefresh.DataSource = dt;
            this.Con.Close();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var log = new Авторизация();
            log.Show();
        }

        /// <summary>
        /// Кнопка добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (this.ProdoName.Text == "" || this.ProdoQty.Text == "")
            {
                MessageBox.Show("Отсутсвуют данные", "Сообщение", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                int total = Convert.ToInt32(this.ProdoPrice.Text)
                * Convert.ToInt32(this.ProdoQty.Text);

                var newRow = new DataGridViewRow();
                newRow.CreateCells(this.OrderDGV);
                newRow.Cells[0].Value = this.n + 1;
                newRow.Cells[1].Value = this.ProdoName.Text;
                newRow.Cells[2].Value = this.ProdoPrice.Text;
                newRow.Cells[3].Value = this.ProdoQty.Text;
                newRow.Cells[4].Value = Convert.ToInt32(this.ProdoPrice.Text)
                    * Convert.ToInt32(this.ProdoQty.Text);
                this.OrderDGV.Rows.Add(newRow);
                this.n++;
                this.Grdtotal = this.Grdtotal + total;
                this.Amtlbl.Text = this.Grdtotal +"";
            }
        }
    }
}
