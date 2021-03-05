using System;
using System.Drawing;
using System.Windows.Forms;

namespace Juego
{
    public partial class frmJuego : Form
    {
        int velocidad;
        Personaje rojo;
        //Personaje azul;
        //Personaje amarillo;
        //Personaje blanco;
        //Personaje verde;
        public frmJuego()
        {
            InitializeComponent();
            velocidad = 10;
            rojo = new Personaje();
            rojo.Velocidad = 2;
            rojo.AddVelocidad(-1);
            //azul = new Personaje("azul", 100, 10);
            //amarillo = new Personaje("amarillo", 50, 5);
            //blanco = new Personaje("blanco", 75, 2);
            //verde = new Personaje("verde",20, 10, new Point(10, 10), new Size(50, 50));
            //MessageBox.Show(verde.ToString());
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (pctPlayer.Location.X - velocidad > 0)
            {
                pctPlayer.Location = new Point(pctPlayer.Location.X - velocidad, pctPlayer.Location.Y);
            }


        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (pctPlayer.Location.X + pctPlayer.Size.Width + velocidad < this.Size.Width)
            {
                pctPlayer.Location = new Point(pctPlayer.Location.X + velocidad, pctPlayer.Location.Y);
            }

        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            if (pctPlayer.Location.Y - 10 - velocidad > 0)
            {
                pctPlayer.Location = new Point(pctPlayer.Location.X, pctPlayer.Location.Y - velocidad);
            }
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            if (pctPlayer.Location.Y + pctPlayer.Size.Height + 40 + velocidad < grpLevel.Height)
            {
                pctPlayer.Location = new Point(pctPlayer.Location.X, pctPlayer.Location.Y + velocidad);
            }
        }



        private void trcVelocidad_Scroll(object sender, EventArgs e)
        {
            // velocidad = int.Parse(nmrVelocidadPlayer.Value.ToString());
            // velocidad = Convert.ToInt32(nmrVelocidadPlayer.Value.ToString());
            // velocidad = (int)nmrVelocidadPlayer.Value;
            velocidad = (int)trcVelocidad.Value;
        }



        private void frmJuego_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'A'|| e.KeyChar == 'a')
            {
               rojo
            }
        }
        private void izquierda()
        {
            if (pctPlayer.Location.X - velocidad > 0)
            {
                pctPlayer.Location = new Point(pctPlayer.Location.X - velocidad, pctPlayer.Location.Y);
            }
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {

        }
    }
}
