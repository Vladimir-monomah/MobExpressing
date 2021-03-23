using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace MobExpress.Управление_товаром
{
    public partial class Форма_категорий : Form
    {
        public Форма_категорий()
        {
            this.InitializeComponent();
        }

        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\vladi\Desktop\MobExpress\MobExpress\MobExpress\MobExpress.mdb;Persist Security Info=True;User ID=admin");
        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Добавление категорий в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.Con.Open();
                string query = "insert into CategoryTbl values(" + this.CatId.Text + ",'"
                    + this.CatNameTbl.Text + "','" + this.CatDescTbl.Text + "')";
                var cmd = new OleDbCommand(query, this.Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Категория добавлена успешна");
                this.Con.Close();
                this.Populate();
                this.CatId.Text = "";
                this.CatNameTbl.Text = "";
                this.CatDescTbl.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Функция выборки из БД
        /// </summary>
        private void Populate()
        {
            this.Con.Open();
            string query = "select * from CategoryTbl";
            var sda = new OleDbDataAdapter(query, this.Con);
            var builder = new OleDbCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            this.CatDGV.DataSource = ds.Tables[0];
            this.Con.Close();
        }

        private void Форма_категорий_Load(object sender, EventArgs e)
        {
            this.Populate();
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CatId.Text = this.CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            this.CatNameTbl.Text = this.CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            this.CatDescTbl.Text = this.CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        /// <summary>
        /// Удаление данных из БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CatId.Text == "")
                {
                    MessageBox.Show("Выберите категорию для удаления");
                }
                else
                {
                    this.Con.Open();
                    string query = "delete from CategoryTbl where CatId=" + this.CatId.Text + "";
                    var cmd = new OleDbCommand(query, this.Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Удаление категории прошло успешно!");
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
        /// Редактирование данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.CatId.Text == "" || this.CatNameTbl.Text == ""
                    || this.CatDescTbl.Text == "")
                {
                    MessageBox.Show("Недостающая информация");
                }
                else
                {
                    this.Con.Open();
                    string query = "Update CategoryTbl set CatName='" + this.CatNameTbl.Text + "'," +
                        " CatDesc='" + this.CatDescTbl.Text + "'where CatId=" +
                        this.CatId.Text + ";";
                    var cmd = new OleDbCommand(query, this.Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Категории успешно обновлены");
                    this.Con.Close();
                    this.Populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            var prod = new ProductForm();
            prod.Show();
            this.Hide();
        }
    }
}
