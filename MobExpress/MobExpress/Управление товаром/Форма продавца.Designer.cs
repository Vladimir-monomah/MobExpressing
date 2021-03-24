namespace MobExpress.Управление_товаром
{
    partial class Форма_продавца
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Форма_продавца));
            this.btnProducts = new System.Windows.Forms.Button();
            this.SellerDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.SellerPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SellerPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSeller = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SellerAge = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SellerID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCategory = new System.Windows.Forms.Button();
            this.SellerName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel = new System.Windows.Forms.Panel();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.SellerFirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SellerLogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProducts
            // 
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProducts.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnProducts.Location = new System.Drawing.Point(3, 149);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(159, 41);
            this.btnProducts.TabIndex = 9;
            this.btnProducts.Text = "Товары";
            this.btnProducts.UseVisualStyleBackColor = true;
            // 
            // SellerDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.SellerDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SellerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SellerDGV.BackgroundColor = System.Drawing.Color.White;
            this.SellerDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellerDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellerDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellerDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SellerDGV.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SellerDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.SellerDGV.EnableHeadersVisualStyles = false;
            this.SellerDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellerDGV.Location = new System.Drawing.Point(528, 111);
            this.SellerDGV.Name = "SellerDGV";
            this.SellerDGV.ReadOnly = true;
            this.SellerDGV.RowHeadersVisible = false;
            this.SellerDGV.RowTemplate.Height = 28;
            this.SellerDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SellerDGV.Size = new System.Drawing.Size(714, 631);
            this.SellerDGV.TabIndex = 18;
            this.SellerDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SellerDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellerDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Chocolate;
            this.SellerDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SellerDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellerDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SellerDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.SellerDGV.ThemeStyle.ReadOnly = true;
            this.SellerDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SellerDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SellerDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellerDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SellerDGV.ThemeStyle.RowsStyle.Height = 28;
            this.SellerDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SellerDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SellerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellerDGV_CellContentClick);
            // 
            // SellerPassword
            // 
            this.SellerPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellerPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SellerPassword.HintForeColor = System.Drawing.Color.Empty;
            this.SellerPassword.HintText = "";
            this.SellerPassword.isPassword = false;
            this.SellerPassword.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.SellerPassword.LineIdleColor = System.Drawing.Color.White;
            this.SellerPassword.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.SellerPassword.LineThickness = 3;
            this.SellerPassword.Location = new System.Drawing.Point(155, 492);
            this.SellerPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SellerPassword.Name = "SellerPassword";
            this.SellerPassword.Size = new System.Drawing.Size(363, 34);
            this.SellerPassword.TabIndex = 17;
            this.SellerPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDelete.Location = new System.Drawing.Point(383, 586);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 41);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnEdit.Location = new System.Drawing.Point(155, 586);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(222, 41);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.Location = new System.Drawing.Point(1, 586);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 41);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Пароль";
            // 
            // SellerPhone
            // 
            this.SellerPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SellerPhone.HintForeColor = System.Drawing.Color.Empty;
            this.SellerPhone.HintText = "";
            this.SellerPhone.isPassword = false;
            this.SellerPhone.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.SellerPhone.LineIdleColor = System.Drawing.Color.White;
            this.SellerPhone.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.SellerPhone.LineThickness = 3;
            this.SellerPhone.Location = new System.Drawing.Point(159, 361);
            this.SellerPhone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SellerPhone.Name = "SellerPhone";
            this.SellerPhone.Size = new System.Drawing.Size(361, 34);
            this.SellerPhone.TabIndex = 10;
            this.SellerPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Телефон";
            // 
            // btnSeller
            // 
            this.btnSeller.FlatAppearance.BorderSize = 0;
            this.btnSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeller.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSeller.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSeller.Location = new System.Drawing.Point(3, 276);
            this.btnSeller.Name = "btnSeller";
            this.btnSeller.Size = new System.Drawing.Size(159, 41);
            this.btnSeller.TabIndex = 11;
            this.btnSeller.Text = "Продажа";
            this.btnSeller.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnClose.Location = new System.Drawing.Point(1400, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 32);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SellerAge
            // 
            this.SellerAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerAge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellerAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SellerAge.HintForeColor = System.Drawing.Color.Empty;
            this.SellerAge.HintText = "";
            this.SellerAge.isPassword = false;
            this.SellerAge.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.SellerAge.LineIdleColor = System.Drawing.Color.White;
            this.SellerAge.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.SellerAge.LineThickness = 3;
            this.SellerAge.Location = new System.Drawing.Point(161, 301);
            this.SellerAge.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SellerAge.Name = "SellerAge";
            this.SellerAge.Size = new System.Drawing.Size(361, 34);
            this.SellerAge.TabIndex = 8;
            this.SellerAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Имя";
            // 
            // SellerID
            // 
            this.SellerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SellerID.HintForeColor = System.Drawing.Color.Empty;
            this.SellerID.HintText = "";
            this.SellerID.isPassword = false;
            this.SellerID.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.SellerID.LineIdleColor = System.Drawing.Color.White;
            this.SellerID.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.SellerID.LineThickness = 3;
            this.SellerID.Location = new System.Drawing.Point(159, 100);
            this.SellerID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SellerID.Name = "SellerID";
            this.SellerID.Size = new System.Drawing.Size(361, 34);
            this.SellerID.TabIndex = 4;
            this.SellerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(307, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Управление продавцами\r\n";
            // 
            // btnCategory
            // 
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCategory.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCategory.Location = new System.Drawing.Point(3, 215);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(159, 41);
            this.btnCategory.TabIndex = 10;
            this.btnCategory.Text = "Категория";
            this.btnCategory.UseVisualStyleBackColor = true;
            // 
            // SellerName
            // 
            this.SellerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SellerName.HintForeColor = System.Drawing.Color.Empty;
            this.SellerName.HintText = "";
            this.SellerName.isPassword = false;
            this.SellerName.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.SellerName.LineIdleColor = System.Drawing.Color.White;
            this.SellerName.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.SellerName.LineThickness = 3;
            this.SellerName.Location = new System.Drawing.Point(159, 174);
            this.SellerName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SellerName.Name = "SellerName";
            this.SellerName.Size = new System.Drawing.Size(361, 34);
            this.SellerName.TabIndex = 6;
            this.SellerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.DarkOrange;
            this.panel.Controls.Add(this.cbAdmin);
            this.panel.Controls.Add(this.SellerFirstName);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.SellerDGV);
            this.panel.Controls.Add(this.SellerLogin);
            this.panel.Controls.Add(this.SellerPassword);
            this.panel.Controls.Add(this.btnDelete);
            this.panel.Controls.Add(this.btnEdit);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.btnAdd);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.SellerPhone);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.SellerAge);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.SellerName);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.SellerID);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(168, 38);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1245, 750);
            this.panel.TabIndex = 7;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.cbAdmin.ForeColor = System.Drawing.Color.White;
            this.cbAdmin.Location = new System.Drawing.Point(142, 542);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(352, 27);
            this.cbAdmin.TabIndex = 21;
            this.cbAdmin.Text = "Является ли администратором";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // SellerFirstName
            // 
            this.SellerFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerFirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellerFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SellerFirstName.HintForeColor = System.Drawing.Color.Empty;
            this.SellerFirstName.HintText = "";
            this.SellerFirstName.isPassword = false;
            this.SellerFirstName.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.SellerFirstName.LineIdleColor = System.Drawing.Color.White;
            this.SellerFirstName.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.SellerFirstName.LineThickness = 3;
            this.SellerFirstName.Location = new System.Drawing.Point(161, 238);
            this.SellerFirstName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SellerFirstName.Name = "SellerFirstName";
            this.SellerFirstName.Size = new System.Drawing.Size(361, 34);
            this.SellerFirstName.TabIndex = 20;
            this.SellerFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Фамилия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(23, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Логин";
            // 
            // SellerLogin
            // 
            this.SellerLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SellerLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SellerLogin.HintForeColor = System.Drawing.Color.Empty;
            this.SellerLogin.HintText = "";
            this.SellerLogin.isPassword = false;
            this.SellerLogin.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.SellerLogin.LineIdleColor = System.Drawing.Color.White;
            this.SellerLogin.LineMouseHoverColor = System.Drawing.Color.WhiteSmoke;
            this.SellerLogin.LineThickness = 3;
            this.SellerLogin.Location = new System.Drawing.Point(159, 427);
            this.SellerLogin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SellerLogin.Name = "SellerLogin";
            this.SellerLogin.Size = new System.Drawing.Size(363, 34);
            this.SellerLogin.TabIndex = 17;
            this.SellerLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Форма_продавца
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 793);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnSeller);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Форма_продавца";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма продавца";
            ((System.ComponentModel.ISupportInitialize)(this.SellerDGV)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProducts;
        private Guna.UI.WinForms.GunaDataGridView SellerDGV;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellerPassword;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellerPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSeller;
        private System.Windows.Forms.Button btnClose;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellerAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCategory;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellerName;
        private System.Windows.Forms.Panel panel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellerFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbAdmin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SellerLogin;
        private System.Windows.Forms.Label label8;
    }
}