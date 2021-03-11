using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVideojuego
{
    public partial class frmUno : Form

    {
        List<PictureBox> ListaObstaculosAmarrillo = new List<PictureBox>();
        Random RnTipoObstaculo = new Random();
        int Velocidad = 3;
        int AnimacionpctCarro1 = 0;
        
        
        public frmUno()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        public void CrearObstaculo(List<PictureBox> ListaElementos, Form panelJuegoUno, int distanciaUno, int distanciaDos);
        {
            int NumeroCarro = 1;
            int TipoObstaculo = RnTipoObstaculo.Next(1, 3);
            int UbicacionObstaculo = RnTipoObtaculo.Next(1, 3);
        }
        

        
    }
}
