﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVisual
{
    public partial class frmVentanaCuatro : Form
    {
        public frmVentanaCuatro()
        {
            InitializeComponent();
        }

        private void FrmCuatro_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frmVentanaCinco frmCinco = new frmVentanaCinco();
            frmCinco.Show();
            prbAumento.Increment(64);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
