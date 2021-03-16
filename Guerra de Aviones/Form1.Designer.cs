namespace Guerra_de_Aviones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.lblIniciar = new System.Windows.Forms.Label();
            this.tmrTiempojuego = new System.Windows.Forms.Timer(this.components);
            this.pctMuroTres = new System.Windows.Forms.PictureBox();
            this.pctMeta = new System.Windows.Forms.PictureBox();
            this.pctMuroDos = new System.Windows.Forms.PictureBox();
            this.pctMuroUno = new System.Windows.Forms.PictureBox();
            this.pctMisilDos = new System.Windows.Forms.PictureBox();
            this.pctMisil = new System.Windows.Forms.PictureBox();
            this.pctAvion = new System.Windows.Forms.PictureBox();
            this.pctFondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctMuroTres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMuroDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMuroUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMisilDos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMisil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Location = new System.Drawing.Point(55, 44);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(45, 13);
            this.lblIntentos.TabIndex = 3;
            this.lblIntentos.Text = "Intentos";
            // 
            // lblIniciar
            // 
            this.lblIniciar.AutoSize = true;
            this.lblIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciar.Location = new System.Drawing.Point(55, 9);
            this.lblIniciar.Name = "lblIniciar";
            this.lblIniciar.Size = new System.Drawing.Size(99, 20);
            this.lblIniciar.TabIndex = 5;
            this.lblIniciar.Text = "Iniciar Juego";
            this.lblIniciar.Click += new System.EventHandler(this.lblIniciar_Click);
            // 
            // tmrTiempojuego
            // 
            this.tmrTiempojuego.Interval = 60;
            this.tmrTiempojuego.Tick += new System.EventHandler(this.tmrTiempojuego_Tick);
            // 
            // pctMuroTres
            // 
            this.pctMuroTres.Image = global::Guerra_de_Aviones.Properties.Resources.Llamas_fuego4;
            this.pctMuroTres.Location = new System.Drawing.Point(49, 401);
            this.pctMuroTres.Name = "pctMuroTres";
            this.pctMuroTres.Size = new System.Drawing.Size(705, 50);
            this.pctMuroTres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMuroTres.TabIndex = 10;
            this.pctMuroTres.TabStop = false;
            // 
            // pctMeta
            // 
            this.pctMeta.Image = global::Guerra_de_Aviones.Properties.Resources._470_4707092_bandera_de_meta_icono_png_download_racing_flags;
            this.pctMeta.Location = new System.Drawing.Point(386, 9);
            this.pctMeta.Name = "pctMeta";
            this.pctMeta.Size = new System.Drawing.Size(45, 34);
            this.pctMeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMeta.TabIndex = 9;
            this.pctMeta.TabStop = false;
            // 
            // pctMuroDos
            // 
            this.pctMuroDos.Image = global::Guerra_de_Aviones.Properties.Resources.Llamas_fuego3;
            this.pctMuroDos.Location = new System.Drawing.Point(753, 0);
            this.pctMuroDos.Name = "pctMuroDos";
            this.pctMuroDos.Size = new System.Drawing.Size(47, 451);
            this.pctMuroDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMuroDos.TabIndex = 8;
            this.pctMuroDos.TabStop = false;
            // 
            // pctMuroUno
            // 
            this.pctMuroUno.Image = global::Guerra_de_Aviones.Properties.Resources.Llamas_fuego1;
            this.pctMuroUno.Location = new System.Drawing.Point(2, 0);
            this.pctMuroUno.Name = "pctMuroUno";
            this.pctMuroUno.Size = new System.Drawing.Size(47, 451);
            this.pctMuroUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMuroUno.TabIndex = 7;
            this.pctMuroUno.TabStop = false;
            // 
            // pctMisilDos
            // 
            this.pctMisilDos.BackColor = System.Drawing.Color.Transparent;
            this.pctMisilDos.Image = global::Guerra_de_Aviones.Properties.Resources.WhatsApp_Image_2021_03_11_at_11_45_10_AM;
            this.pctMisilDos.Location = new System.Drawing.Point(462, 12);
            this.pctMisilDos.Name = "pctMisilDos";
            this.pctMisilDos.Size = new System.Drawing.Size(45, 67);
            this.pctMisilDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMisilDos.TabIndex = 6;
            this.pctMisilDos.TabStop = false;
            // 
            // pctMisil
            // 
            this.pctMisil.BackColor = System.Drawing.Color.Transparent;
            this.pctMisil.Image = global::Guerra_de_Aviones.Properties.Resources.WhatsApp_Image_2021_03_11_at_11_45_10_AM;
            this.pctMisil.Location = new System.Drawing.Point(294, 9);
            this.pctMisil.Name = "pctMisil";
            this.pctMisil.Size = new System.Drawing.Size(45, 67);
            this.pctMisil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMisil.TabIndex = 2;
            this.pctMisil.TabStop = false;
            // 
            // pctAvion
            // 
            this.pctAvion.BackColor = System.Drawing.Color.Transparent;
            this.pctAvion.Image = global::Guerra_de_Aviones.Properties.Resources.avionguerra1;
            this.pctAvion.Location = new System.Drawing.Point(367, 308);
            this.pctAvion.Name = "pctAvion";
            this.pctAvion.Size = new System.Drawing.Size(79, 68);
            this.pctAvion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAvion.TabIndex = 1;
            this.pctAvion.TabStop = false;
            // 
            // pctFondo
            // 
            this.pctFondo.Image = global::Guerra_de_Aviones.Properties.Resources.WhatsApp_Image_2021_03_11_at_11_42_31_AM;
            this.pctFondo.Location = new System.Drawing.Point(2, 0);
            this.pctFondo.Name = "pctFondo";
            this.pctFondo.Size = new System.Drawing.Size(798, 451);
            this.pctFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFondo.TabIndex = 0;
            this.pctFondo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.pctMuroTres);
            this.Controls.Add(this.pctMeta);
            this.Controls.Add(this.pctMuroDos);
            this.Controls.Add(this.pctMuroUno);
            this.Controls.Add(this.pctMisilDos);
            this.Controls.Add(this.lblIniciar);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.pctMisil);
            this.Controls.Add(this.pctAvion);
            this.Controls.Add(this.pctFondo);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Guerra de Aviones";
            ((System.ComponentModel.ISupportInitialize)(this.pctMuroTres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMuroDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMuroUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMisilDos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMisil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctFondo;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.Label lblIniciar;
        private System.Windows.Forms.Timer tmrTiempojuego;
        private System.Windows.Forms.PictureBox pctMisilDos;
        private System.Windows.Forms.PictureBox pctAvion;
        private System.Windows.Forms.PictureBox pctMuroUno;
        private System.Windows.Forms.PictureBox pctMuroDos;
        private System.Windows.Forms.PictureBox pctMeta;
        private System.Windows.Forms.PictureBox pctMisil;
        private System.Windows.Forms.PictureBox pctMuroTres;
    }
}

