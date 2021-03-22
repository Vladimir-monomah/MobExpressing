using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobExpress.Управление_товаром
{
    public partial class SellingForm : Form
    {
        public SellingForm(Int64 userId)
        {
            InitializeComponent();
        }

        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\vladi\Desktop\MobExpress\MobExpress\MobExpress.mdb;Persist Security Info=True;User ID=admin");

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
        }

        private void ProdoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ProdoName.Text = this.ProdoDGV.SelectedRows[0].Cells[0].Value.ToString();
            this.ProdoPrice.Text = this.ProdoDGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            this.Datelbl.Text = DateTime.Today.Day.ToString() + "/" +
                DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
