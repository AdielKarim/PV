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
    public partial class FrmDos : Form
    {
        public FrmDos()
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
            FrmTres frmTres = new FrmTres();
            frmTres.Show();

            prbAumento.Increment(40);
        }
    }
}
