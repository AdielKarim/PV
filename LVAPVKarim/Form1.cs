﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LVAPVKarim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLlamarAformaDos_Click(object sender, EventArgs e)
        {
            FrmDos frmDos = new FrmDos();
            frmDos.Show();
        }

        private void btnLlamarAFormaTres_Click(object sender, EventArgs e)
        {
            FrmTres frmTres = new FrmTres();
            frmTres.Show();
        }
    }
}
