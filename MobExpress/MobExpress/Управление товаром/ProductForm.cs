using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MobExpress.Управление_товаром
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            this.InitializeComponent();
        }

        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\vladi\Desktop\MobExpress\MobExpress\MobExpress\MobExpress.mdb;Persist Security Info=True;User ID=admin");

        /// <summary>
        /// Закрыть приложение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            this.cbCategory.ValueMember = "catName";
            this.cbCategory.DataSource = dt;
            this.cbCategoryRefresh.ValueMember = "catName";
            this.cbCategoryRefresh.DataSource = dt;
            this.Con.Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            this.FileCombo();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            var cat = new Форма_категорий();
            cat.Show();
            this.Hide();
        }

        /// <summary>
        /// Функция выборки из БД
        /// </summary>
        private void Populate()
        {
            this.Con.Open();
            string query = "select * from ProductTbl";
            var sda = new OleDbDataAdapter(query, this.Con);
            var builder = new OleDbCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            this.ProdDGV.DataSource = ds.Tables[0];
            this.Con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.Con.Open();
                string query = "insert into ProductTbl values(" + this.ProdId.Text + ",'"
                    + this.ProdName.Text + "'," + this.ProdQty.Text + "," +
                    "" + this.ProdPrice.Text + "," +
                    "'" + this.cbCategory.SelectedValue.ToString() + "')";
                var cmd = new OleDbCommand(query, this.Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Товар добавлен успешно!");
                this.Con.Close();
                this.Populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ProdId.Text = this.ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            this.ProdName.Text = this.ProdDGV.SelectedRows[0].Cells[1].Value.ToString();
            this.ProdQty.Text = this.ProdDGV.SelectedRows[0].Cells[2].Value.ToString();
            this.ProdPrice.Text = this.ProdDGV.SelectedRows[0].Cells[3].Value.ToString();
            this.cbCategory.SelectedValue = this.ProdDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        /// <summary>
        /// Удавление данных из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ProdId.Text == "")
                {
                    MessageBox.Show("Выберите товар для удаления");
                }
                else
                {
                    this.Con.Open();
                    string query = "delete from ProductTbl where ProdId=" + this.ProdId.Text + "";
                    var cmd = new OleDbCommand(query, this.Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Удаление товара прошло успешно!");
                    this.Con.Close();
                    this.Populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Редактирование товара
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ProdId.Text == "" || this.ProdName.Text == ""
                    || this.ProdQty.Text == "" || this.ProdPrice.Text == "")
                {
                    MessageBox.Show("Недостающая информация");
                }
                else
                {
                    this.Con.Open();
                    string query = "Update ProductTbl set ProdName='" + this.ProdName.Text + "'," +
                        " ProdQty='" + this.ProdQty.Text + "',ProdPrice='" + this.ProdPrice.Text +
                        "',ProdCat='" + this.cbCategory.SelectedValue.ToString() +
                        "'where ProdId=" + this.ProdId.Text + ";";
                    var cmd = new OleDbCommand(query, this.Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Товар успешно обновлены");
                    this.Con.Close();
                    this.Populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            this.Populate();
        }

        private void cbCategoryRefresh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Con.Open();
            string query = "select * from ProductTbl where ProdCat='" + this.cbCategory.SelectedValue.ToString() + "'";
            var sda = new OleDbDataAdapter(query, this.Con);
            var builder = new OleDbCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            this.ProdDGV.DataSource = ds.Tables[0];
            this.Con.Close();
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            var seller = new Форма_продавца();
            seller.Show();
        }

        private void btnSelling_Click(object sender, EventArgs e)
        {

        }
    }
}
