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
    public partial class frmVentanaDos : Form
    {
        public frmVentanaDos()
        {
            InitializeComponent();
        }

        private void lstEstados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //frmVentanaUno frmVentanaUno = new frmVentanaUno();
            //frmVentanaUno.Show();
            
            this.Close();
            
        }

        private void rdbSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frmVentanaTres frmTres = new frmVentanaTres();
            frmTres.Show();

            prbAumento.Increment(32);
        }

        private void prbAumento_Click(object sender, EventArgs e)
        {

        }
    }
}
