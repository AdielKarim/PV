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
            
            
            pctMuroUno.Visible = false;
            pctMuroDos.Visible = false;
            pctMuroTres.Visible = false;
            
            pctMeta.Visible = false;
           
            
            pctAvion.Visible = false;
            lblIntentos.Visible = false;
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

           


            if (pctAvion.Bounds.IntersectsWith(pctMuroUno.Bounds))
            {
                MessageBox.Show("GAMEOOOVER!");
            }
            
            if (pctAvion.Bounds.IntersectsWith(pctMuroDos.Bounds))
            {
                MessageBox.Show("GAMEOOOOVER!");
            }
            
            
            if (pctAvion.Bounds.IntersectsWith(pctMuroTres.Bounds))
            {
                MessageBox.Show("GAMEOOOOOVER!");
            }
            
           
            
            if (pctAvion.Bounds.IntersectsWith(pctMeta.Bounds))
            {
                MessageBox.Show("Congratulations!!!");
            }

            

            pctAvion.Location = new System.Drawing.Point(x, y);
            i = x;
            j = y;
        }



        private void tmrTiempojuego_Tick(object sender, EventArgs e)
        {
            Random rdn = new Random();
            int a = rdn.Next(50, 550);
            int b = rdn.Next(50, 550);
            int c = rdn.Next(50, 550);
            int d = rdn.Next(50, 550);
            int f = rdn.Next(50, 550);
            int g = rdn.Next(50, 550);
            contador = contador + 1;
            if ((pctMisil.Top < 500) && (pctMisil.Top < 500) && (pctMisil.Top < 500))
            {
                pctMisil.Top = pctMisil.Top + 13;
                pctMisilDos.Top = pctMisilDos.Top + 13;
                
            }
            else
            {

                pctMisil.Visible = true;
                pctMisilDos.Visible = true;
               
                pctMisil.Location = new Point(a, 0);
                pctMisilDos.Location = new Point(b, 0);
                
            }

            if (pctMisil.Visible == true)
            {
                if (pctMisil.Bounds.IntersectsWith(pctAvion.Bounds))
                {

                    intentos = intentos + 1;
                    lblIntentos.Text = "Intentos: 0" + intentos;
                    if (intentos > 2)
                    {
                        lblIntentos.Visible = false;
                        tmrTiempojuego.Stop();
                        MessageBox.Show("KABOOOOM!");

                        pctMisil.Visible = false;
                        pctMisilDos.Visible = false;
                       

                        pctAvion.Visible = false;
                        pctFondo.Visible = true;
                        lblIntentos.Visible = true;

                        lblIntentos.Text = "Intentos 01";
                    }
                    else
                    {
                        pctAvion.Location = new System.Drawing.Point(300, 400);
                        pctMisil.Location = new Point(a, 0);
                        pctMisilDos.Location = new Point(b, 0);
                        

                    }

                }

            }
            if (pctMisilDos.Visible == true)
            {
                if (pctMisilDos.Bounds.IntersectsWith(pctAvion.Bounds))

                {
                    intentos = intentos + 1;
                    lblIntentos.Text = "Intentos: 0" + intentos;
                    if (intentos > 2)
                    {
                        lblIntentos.Visible = true;
                        tmrTiempojuego.Stop();
                        MessageBox.Show("POOOOOOF!");

                        pctMisil.Visible = false;
                        pctMisilDos.Visible = false;
                       


                        pctAvion.Visible = false;
                        pctFondo.Visible = true;
                        lblIntentos.Visible = true;

                        lblIntentos.Text = "Intentos: 01";

                    }
                    else
                    {
                        pctAvion.Location = new System.Drawing.Point(304, 211);
                        pctMisil.Location = new Point(a, 0);
                        pctMisilDos.Location = new Point(b, 0);

                    }

                }

            }
            if (pctMuroUno.Visible == true)
            {
                if (pctMuroUno.Bounds.IntersectsWith(pctAvion.Bounds))
                {
                    intentos = intentos + 1;
                    lblIntentos.Text = "Intentos: 0" + intentos;
                    if (intentos > 1)
                    {
                        lblIntentos.Visible = true;
                        tmrTiempojuego.Stop();

                        pctMuroUno.Visible = false;
                        pctMuroDos.Visible = false;
                        pctMuroTres.Visible = false;
                        pctMeta.Visible = false;
                        pctMisilDos.Visible = false;
                        pctMisil.Visible = false;
                        pctMisilDos.Visible = false;
                        pctAvion.Visible = false;

                        pctAvion.Visible = false;
                        pctFondo.Visible = true;
                        lblIntentos.Visible = true;

                        lblIntentos.Text = "Intentos: 01";
                    }
                    else
                    {
                        pctAvion.Location = new System.Drawing.Point(304, 211);
                        pctMisil.Location = new Point(a, 0);
                        pctMisilDos.Location = new Point(b, 0);
                        pctMuroUno.Location = new Point(c, 0);
                        pctMuroDos.Location = new Point(d, 0);
                        pctMuroTres.Location = new Point(f, 0);
                        pctMeta.Location = new Point(g, 0);
                    }
                }
            }
            if (pctMuroDos.Visible == true)
            {
                if (pctMuroDos.Bounds.IntersectsWith(pctAvion.Bounds))
                {
                    intentos = intentos + 1;
                    lblIntentos.Text = "Intentos: 0" + intentos;
                    if (intentos > 1)
                    {
                        lblIntentos.Visible = true;
                        tmrTiempojuego.Stop();

                        pctMuroDos.Visible = false;
                        pctMuroUno.Visible = false;
                        pctMuroTres.Visible = false;
                        pctMeta.Visible = false;
                        pctMisil.Visible = false;
                        pctMisilDos.Visible = false;
                        

                        pctAvion.Visible = false;
                        pctFondo.Visible = true;
                        lblIntentos.Visible = true;
                        
                        lblIntentos.Text = "Intentos: 01";
                    }
                    else
                    {
                        pctAvion.Location = new System.Drawing.Point(304, 211);
                        pctMisil.Location = new Point(a, 0);
                        pctMisilDos.Location = new Point(b, 0);
                        pctMuroUno.Location = new Point(c, 0);
                        pctMuroDos.Location = new Point(d, 0);
                        pctMuroTres.Location = new Point(f, 0);
                        pctMeta.Location = new Point(g, 0);
                    }
                }
            }
            if (pctMuroTres.Visible == true)
            {
                if (pctMuroTres.Bounds.IntersectsWith(pctAvion.Bounds))
                {
                    intentos = intentos + 1;
                    lblIntentos.Text = "Intentos: 0" + intentos;
                    if (intentos > 1)
                    {
                        lblIntentos.Visible = true;
                        tmrTiempojuego.Stop();

                        pctMuroTres.Visible = false;
                        pctMuroDos.Visible = false;
                        pctMuroUno.Visible = false;
                        pctMeta.Visible = false;
                        pctMisil.Visible = false;
                        pctMisilDos.Visible = false;
                        

                        pctAvion.Visible = false;
                        pctFondo.Visible = true;
                        lblIntentos.Visible = true;

                        lblIntentos.Text = "Intentos: 01";
                    }
                    else
                    {
                        pctAvion.Location = new System.Drawing.Point(304, 211);
                        pctMisil.Location = new Point(a, 0);
                        pctMisilDos.Location = new Point(b, 0);
                        pctMuroUno.Location = new Point(c, 0);
                        pctMuroDos.Location = new Point(d, 0);
                        pctMuroTres.Location = new Point(f, 0);
                        pctMeta.Location = new Point(g, 0);

                    }
                }
            }
            if (pctMeta.Visible == true)
            {
                if (pctMeta.Bounds.IntersectsWith(pctAvion.Bounds))
                {
                    intentos = intentos + 1;
                    lblIntentos.Text = "Intentos: 0" + intentos;
                    if (intentos > 1)
                    {
                        lblIntentos.Visible = true;
                        tmrTiempojuego.Stop();

                        pctMeta.Visible = false;
                        pctMuroDos.Visible = false;
                        pctMuroUno.Visible = false;
                        pctMuroTres.Visible = false;
                        pctMisil.Visible = false;
                        pctMisilDos.Visible = false;
                       

                        pctAvion.Visible = false;
                        pctFondo.Visible = true;
                        lblIntentos.Visible = true;

                        lblIntentos.Text = "Intentos: 01";
                    }
                    else
                    {
                        pctAvion.Location = new System.Drawing.Point(304, 211);
                        pctMisil.Location = new Point(a, 0);
                        pctMisilDos.Location = new Point(b, 0);
                        pctMuroUno.Location = new Point(c, 0);
                        pctMuroDos.Location = new Point(d, 0);
                        pctMuroTres.Location = new Point(f, 0);
                        pctMeta.Location = new Point(g, 0);
                    }
                }
            }
            

        }

        private void lblIniciar_Click(object sender, EventArgs e)
        {
            pctAvion.Location = new Point(367, 308);
            pctMisil.Visible = true;
            pctMisilDos.Visible = true;
            pctMuroUno.Visible = true;
            pctMuroDos.Visible = true;
            pctMuroTres.Visible = true;
            pctMeta.Visible = true;
            pctFondo.Visible = true;
            pctAvion.Visible = true;
            lblIntentos.Visible = true;

            this.pctMisil.SizeMode = PictureBoxSizeMode.StretchImage;

            Random rdn = new Random();
            int a = rdn.Next(50, 550);
            int b = rdn.Next(50, 550);
            int c = rdn.Next(50, 550);
            int d = rdn.Next(50, 550);
            int f = rdn.Next(50, 550);
            int g = rdn.Next(50, 550);
            
            
            pctMisil.Location = new Point(a, 0);
            pctMisilDos.Location = new Point(b, 0);

            intentos = 1;
            tmrTiempojuego.Start();
            
            
        }

        
    }
}
