﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobExpress
{
    public partial class Загрузочный_файл : Form
    {
        public Загрузочный_файл()
        {
            this.InitializeComponent();
        }

        int startpion = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            this.startpion += 1;
            this.LoadingProgressBar.Value = this.startpion;
            if (this.LoadingProgressBar.Value == 100)
            {
                this.LoadingProgressBar.Value = 0;
                this.timer.Stop();
                var log = new Авторизация();
                this.Hide();
                log.Show();
            }
        }

        private void Загрузочный_файл_Load(object sender, EventArgs e)
        {
            this.timer.Start();
        }
    }
}
