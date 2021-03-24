using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace MobExpress.Управление_товаром
{
    public partial class Форма_продавца : Form
    {
        public Форма_продавца()
        {
            this.InitializeComponent();
        }
        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=MobExpress.mdb;Persist Security Info=True;User ID=admin");
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
        /// Функция выборки из БД
        /// </summary>
        private void Populate()
        {
            this.Con.Open();
            string query = "select * from Пользователь";
            var sda = new OleDbDataAdapter(query, this.Con);
            var builder = new OleDbCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            this.SellerDGV.DataSource = ds.Tables[0];
            this.Con.Close();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            this.Populate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.Con.Open();
                string query = "insert into Пользователь values("
                    + this.SellerID.Text + ",'"
                    + this.SellerName.Text + "',"
                    + this.SellerFirstName.Text + ","
                    + this.SellerAge.Text + ","
                    + this.SellerLogin.Text+","
                    + this.SellerPhone.Text + ","
                    + "'" + this.SellerPassword.Text + "',"
                    + (this.cbAdmin.Checked ? "true" : "false") + ")";
                var cmd = new OleDbCommand(query, this.Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Продавец добавлен успешно!");
                this.Con.Close();
                this.Populate();
                this.Con.Close();
                this.Populate();
                this.SellerID.Text = "";
                this.SellerName.Text = "";
                this.SellerFirstName.Text = "";
                this.SellerAge.Text = "";
                this.SellerLogin.Text = "";
                this.SellerPhone.Text = "";
                this.SellerPassword.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SellerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SellerID.Text = this.SellerDGV.SelectedRows[0].Cells[0].Value.ToString();
            this.SellerName.Text = this.SellerDGV.SelectedRows[0].Cells[1].Value.ToString();
            this.SellerFirstName.Text = this.SellerDGV.SelectedRows[0].Cells[2].Value.ToString();
            this.SellerAge.Text = this.SellerDGV.SelectedRows[0].Cells[3].Value.ToString();
            this.SellerLogin.Text = this.SellerDGV.SelectedRows[0].Cells[4].Value.ToString();
            this.SellerPhone.Text = this.SellerDGV.SelectedRows[0].Cells[5].Value.ToString();
            this.SellerPassword.Text = this.SellerDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SellerID.Text == "")
                {
                    MessageBox.Show("Выберите продавца для удаления");
                }
                else
                {
                    this.Con.Open();
                    string query = "delete from Пользователь where SellerId=" + this.SellerID.Text + "";
                    var cmd = new OleDbCommand(query, this.Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Удаление продавца прошло успешно!");
                    this.Con.Close();
                    this.Populate();
                    this.SellerID.Text = "";
                    this.SellerName.Text = "";
                    this.SellerAge.Text = "";
                    this.SellerPhone.Text = "";
                    this.SellerPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.SellerID.Text == "" || this.SellerName.Text == ""
                    || this.SellerAge.Text == "" || this.SellerPhone.Text == ""
                    || this.SellerPassword.Text == "")
                {
                    MessageBox.Show("Недостающая информация");
                }
                else
                {
                    this.Con.Open();
                    string query = "Update Пользователь set SelelrName='" + this.SellerName.Text + "'," +
                        " SellerAge='" + this.SellerAge.Text + "',SellerPhone='" + this.SellerPhone.Text +
                        "',SellerPassword='" + this.SellerPassword.Text +
                        "'where SellerId=" + this.SellerID.Text + ";";
                    var cmd = new OleDbCommand(query, this.Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Продавец успешно обновлены");
                    this.Con.Close();
                    this.Populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
