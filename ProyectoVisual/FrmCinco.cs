using System;
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
    public partial class frmVentanaCinco : Form
    {
        public frmVentanaCinco()
        {
            InitializeComponent();
        }

        private void lblAuxilioALaPolicia_Click(object sender, EventArgs e)
        {

        }

        private void rdbBien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbMal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frmVentanaSeis frmSeis = new frmVentanaSeis();
            frmSeis.Show();
            prbAumento.Increment(80);


        }

        private void prbAumento_Click(object sender, EventArgs e)
        {

        }
    }
}
