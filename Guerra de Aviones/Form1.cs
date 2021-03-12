using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guerra_de_Aviones
{
    public partial class Form1 : Form
    {
        public int contador;
        public int puntaje;
        public int dificultad = 1;
        public int intentos;
        public int i, j;

        public Form1()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Form1_Keydown);
            pctMisil.Visible = false;
            pctMisilDos.Visible = false;
            pctAvion.Visible = false;
            lblIntentos.Visible = false;
            lblPuntaje.Visible = false;
            pctFondo.Visible = true;
           
        }

        private void Form1_Keydown(object sender, KeyEventArgs e)
        {
            int x = pctAvion.Location.X;
            int y = pctAvion.Location.Y;


            if (e.KeyCode == Keys.Right)
            { x += 13; }
            if (e.KeyCode == Keys.Left)
            { x -= 13; }
            if (e.KeyCode == Keys.Up)
            { y -= 13; }
            if (e.KeyCode == Keys.Down)
            { y += 13; }





            pctAvion.Location = new System.Drawing.Point(x, y);
            i = x;
            j = y;
        }

        private void tmrTiempojuego_Tick(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int a = rdn.Next(50, 550);
            int b = rdn.Next(50, 550);
            contador = contador + 1;
            if ((pctMisil.Top < 500) && (pctMisil.Top < 500) && (pctMisil.Top < 500))
            {
                pctMisil.Top = pctMisil.Top + 11;
                pctMisilDos.Top = pctMisilDos.Top + 12;
            }
            else
            {

                pctMisil.Visible = true;
                pctMisilDos.Visible = true;
                
                pctMisil.Location = new Point(a, 0);
                pctMisilDos.Location = new Point(b, 0);

                if (pctMisil.Visible == true)
            {
                    if (pctMisil.Bounds.IntersectsWith(pctAvion.Bounds))
                    {

                        intentos = intentos + 1;
                        lblIntentos.Text = "Intentos: 0" + intentos;
                        if (intentos > 3)
                        {
                            lblIntentos.Visible = false;
                            tmrTiempojuego.Stop();
                            //Perdedor Intenta = new Perdedor();
                            //Intenta.Show();


                            pctMisil.Visible = false;
                            pctMisilDos.Visible = false;
                            

                            pctAvion.Visible = false;
                            pctFondo.Visible = true;
                            lblIntentos.Visible = true;

                            lblIntentos.Text = "Intentos: 01";
                        }
                        else
                        {
                            pctAvion.Location = new System.Drawing.Point(300, 400);
                            pctMisil.Location = new Point(a, 0);
                            pctMisilDos.Location = new Point(b, 0);
                            
                        }

                    }

                }

            }
        }




        private void lblIniciar_Click(object sender, EventArgs e)
        {
            pctAvion.Location = new Point(304, 211);
            pctMisil.Visible = true;
            pctMisilDos.Visible = true;
            pctFondo.Visible = true;
            pctAvion.Visible = true;
            lblIntentos.Visible = true;

            this.pctMisil.SizeMode = PictureBoxSizeMode.StretchImage;

                Random rdn = new Random();
            int a = rdn.Next(50, 550);
            int b = rdn.Next(50, 550);
            pctMisil.Location = new Point(a, 0);
            pctMisilDos.Location = new Point(b, 0);

            intentos = 1;
            tmrTiempojuego.Start();

            puntaje = 0;
            lblPuntaje.Text = "Puntaje:0";
        }

        
    }
}
