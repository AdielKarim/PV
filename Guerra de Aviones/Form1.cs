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
        }

        private void lblIniciar_Click(object sender, EventArgs e)
        {
            pctAvion.Location = new Point(304, 211);
            pctMisil.Visible = true;
            pctFondo.Visible = true;
            pctAvion.Visible = true;
            lblIntentos.Visible = true;

            this.pctMisil.SizeMode = PictureBoxSizeMode.StretchImage;

                Random rdn = new Random();
            int a = rdn.Next(50, 550);
            pctMisil.Location = new Point(a, 0);

            intentos = 1;
            tmrTiempojuego.Start();

            puntaje = 0;
            lblPuntaje.Text = "Puntaje:0";
        }

        
    }
}
