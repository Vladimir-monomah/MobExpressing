using MobExpress.MobExpressDataSetTableAdapters;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using static MobExpress.MobExpressDataSet;

namespace MobExpress.Управление_товаром
{
    public partial class Форма_продавца : Form
    {
        private ПользовательRow пользователь;

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

        private bool CheckTextBoxes()
        {
            if (this.SellerID.Text == "" || this.SellerName.Text == "" || 
                this.SellerFirstName.Text == "" || this.SellerAge.Text == "" || 
                this.SellerPhone.Text==""||this.SellerPassword.Text=="")
            {
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!this.CheckTextBoxes())
            {
                MessageBox.Show("Заполните необходимые поля!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var idEmployee = this.пользователь?.Id_user;
            var adapter = new ПользовательTableAdapter();
            adapter.Fill(EntityManager.UserDataTable);
            var savingUser = EntityManager.UserDataTable.FindById_user(idEmployee ?? -1)
                ?? EntityManager.UserDataTable.NewПользовательRow();

            savingUser.Id_user = Convert.ToInt32(this.SellerID.Text);
            savingUser.Имя = this.SellerName.Text;
            savingUser.Фамилия = this.SellerFirstName.Text;
            savingUser.Возраст = Convert.ToInt32(this.SellerAge.Text);
            savingUser.Телефон = Convert.ToInt32(this.SellerPhone.Text);
            savingUser.Логин = this.SellerLogin.Text;
            savingUser.Пароль = this.SellerPassword.Text;

            try
            {
                if (this.пользователь == null)
                {
                    EntityManager.UserDataTable.AddПользовательRow(savingUser);
                    EntityManager.UpdateUsers();
                }
                else
                {
                    this.пользовательTableAdapter.Adapter.Update(savingUser.Table);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var message = this.пользователь == null
                ? "Добавление прошло успешно!"
                : "Изменение завершено успешно!";
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK);
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

        private void Форма_продавца_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mobExpressDataSet.Пользователь". При необходимости она может быть перемещена или удалена.
            this.пользовательTableAdapter.Fill(this.mobExpressDataSet.Пользователь);

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            var product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            var cat = new Форма_категорий();
            cat.Show();
            this.Hide();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var log = new Авторизация();
            log.Show();
        }
    }
}
