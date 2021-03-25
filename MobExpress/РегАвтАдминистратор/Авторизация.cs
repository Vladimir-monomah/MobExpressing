using MobExpress.РегАвтАдминистратор;
using MobExpress.Управление_товаром;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MobExpress
{
    public partial class Авторизация : Form
    {
        private string password = "ntvHA2s1y+ryOZizPQ1WHQ==";

        int counter = 0;

        public Авторизация()
        {
            this.InitializeComponent();
        }

        public static string Имя = "";

        /// <summary>
        /// Закрытие программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Открыть окно регистрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReg_Click(object sender, EventArgs e)
        {
            var открыть = new Регистрация(this.password);
            открыть.Show();
        }

        /// <summary>
        /// Кнопка авторизации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.TbLogin.Text == "" && this.TbPassword.Text == "")
            {
                MessageBox.Show("Вы не ввели логин или пароль!Пожалуйста, заполните поля!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Проверка на количество ввода логина и пароля 
            this.counter++;
            if (string.IsNullOrEmpty(this.TbLogin.Text))
            {
                this.TbLogin.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.TbPassword.Text))
            {
                this.TbPassword.Focus();
                return;
            }
            else if (this.counter >= 3)
            {
                this.TbLogin.Enabled = false;
                this.TbPassword.Enabled = false;
            }

            var loginCondition = $"логин = '{this.TbLogin.Text}' AND пароль = '{this.TbPassword.Text}' ";
            var user = EntityManager.FilterUsers(loginCondition).FirstOrDefault();
            if (user != null)
            {
                if (user.Является_администратором)
                {
                    var формаАдминистратора = new ProductForm();
                    this.Hide();
                    формаАдминистратора.Show();
                }
                else
                {
                    var открыть = new SellingForm(user.Id_user,user);
                    this.Hide();
                    открыть.Show();
                }
            }
            else
            {
                MessageBox.Show("Вы ввели неверный логин или пароль!Пользователь в базе не найден!", "Сообщение",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Авторизация_Load(object sender, EventArgs e)
        {

        }
    }
}
