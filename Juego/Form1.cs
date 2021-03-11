using System;
using System.Drawing;
using System.Windows.Forms;

namespace Juego
{
    public partial class frmJuego : Form
    {
        int velocidad;
        int positionFrame;
        Personaje Link;
        Personaje Enemigo;
        //Personaje azul;
        //Personaje amarillo;
        //Personaje blanco;
        //Personaje verde;
        public frmJuego()
        {
            InitializeComponent();
            velocidad = 10;
            positionFrame = 0;
            //rojo = new Personaje();
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
            Link.Mover(e.KeyChar);
            pctPlayer.Location = Link.Posicion;

        }
        private void izquierda()
        {
            
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
            Link = new Personaje();
            pctPlayer.Location = Link.Posicion;
            pctPlayer.Size = Link.Tamanio;
            pctPlayer.Image = Link.GetFrame(0);
           
        }

        private void tmrPlayer_Tick(object sender, EventArgs e)
        {
            if (positionFrame <40 )
            {
                pctPlayer.Image = Link.GetFrame(positionFrame);
                positionFrame++;
            }
            else
            {
                positionFrame = 0;
            }
        }
    }
}
