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
    public partial class FrmTres : Form
    {
        public FrmTres()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Siguientes_Click(object sender, EventArgs e)
        {
            FrmCuatro frmCuatro = new FrmCuatro();
            frmCuatro.Show();
            prbAumento.Increment(60);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
