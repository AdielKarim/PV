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
    public partial class FrmTres : Form
    {
        public FrmTres()
        {
            InitializeComponent();
        }

        private void btnLlamarAFormaDos_Click(object sender, EventArgs e)
        {
            FrmDos frmDos = new FrmDos();
            frmDos.Show();
        }
    }
}
