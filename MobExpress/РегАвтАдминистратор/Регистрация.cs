using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MobExpress.РегАвтАдминистратор
{
    public partial class Регистрация : Form
    {
        private string password;

        public Регистрация(string password)
        {
            this.InitializeComponent();
        }

        //public static string Encrypt(string plainText, string password, string salt = "Kosher", string hashAlgorithm = "SHA1",
        //    int passwordInterations = 2, string initialVector = "PFRna73*aze01xY1", int keySize = 256)
        //{
        //    if (string.IsNullOrEmpty(plainText))
        //        return "";
        //
        //    byte[] initialVectorBytes = Encoding.ASCII.GetBytes(initialVector);
        //    byte[] saltValueBytes = Encoding.ASCII.GetBytes(salt);
        //    byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
        //
        //    var derivedPassword = new PasswordDeriveBytes(password, saltValueBytes, hashAlgorithm, passwordInterations);
        //    byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);
        //    var symmetricKey = new RijndaelManaged();
        //    symmetricKey.Mode = CipherMode.CBC;
        //
        //    byte[] cipherTextBytes = null;
        //
        //    using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initialVectorBytes))
        //    {
        //        using (var memStream = new MemoryStream())
        //        {
        //            using (CryptoStream cryptoStream = new CryptoStream(memStream, encryptor, CryptoStreamMode.Write))
        //            {
        //                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
        //                cryptoStream.FlushFinalBlock();
        //                cipherTextBytes = memStream.ToArray();
        //                memStream.Close();
        //                cryptoStream.Close();
        //            }
        //        }
        //    }
        //    symmetricKey.Clear();
        //    return Convert.ToBase64String(cipherTextBytes);
        //}

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Проверка заполненности полей
        /// </summary>
        /// <returns></returns>
        private bool CheckTextBoxes()
        {
            if (this.TbName.Text == "" || this.TbFirstName.Text == "" ||
                this.TbPhone.Text == "" || this.TbLogin.Text == "" ||
                this.TbPassword.Text == "")
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Кнопка зарегистрировать пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReg_Click(object sender, EventArgs e)
        {
            if (!this.CheckTextBoxes())
            {
                MessageBox.Show("Заполните все поля","Сообщение",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            var newUser = EntityManager.UserDataTable.NewПользовательRow();
            newUser.Имя = this.TbName.Text;
            newUser.Фамилия = this.TbFirstName.Text;
            newUser.Телефон = Convert.ToInt32(this.TbPhone.Text);
            newUser.Логин = this.TbLogin.Text;
            newUser.Пароль = this.TbPassword.Text;
            EntityManager.UserDataTable.AddПользовательRow(newUser);
            EntityManager.UpdateUsers();

            MessageBox.Show("Регистрация прошла успешна", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            var открыть = new Авторизация();
            открыть.Show();
        }

        /// <summary>
        /// Функция запрета ввода цифр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        /// <summary>
        /// Функция запрета ввода букв
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (Char.IsPunctuation(e.KeyChar))) return;
            else
                e.Handled = true;
        }
    }
}
