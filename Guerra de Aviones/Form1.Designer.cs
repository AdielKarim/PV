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
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.pctMisil = new System.Windows.Forms.PictureBox();
            this.pctAvion = new System.Windows.Forms.PictureBox();
            this.pctFondo = new System.Windows.Forms.PictureBox();
            this.lblIniciar = new System.Windows.Forms.Label();
            this.tmrTiempojuego = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctMisil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Location = new System.Drawing.Point(735, 39);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(45, 13);
            this.lblIntentos.TabIndex = 3;
            this.lblIntentos.Text = "Intentos";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(735, 12);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(43, 13);
            this.lblPuntaje.TabIndex = 4;
            this.lblPuntaje.Text = "Puntaje";
            // 
            // pctMisil
            // 
            this.pctMisil.BackColor = System.Drawing.Color.Transparent;
            this.pctMisil.Image = global::Guerra_de_Aviones.Properties.Resources.WhatsApp_Image_2021_03_11_at_11_45_10_AM;
            this.pctMisil.Location = new System.Drawing.Point(342, 12);
            this.pctMisil.Name = "pctMisil";
            this.pctMisil.Size = new System.Drawing.Size(100, 103);
            this.pctMisil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMisil.TabIndex = 2;
            this.pctMisil.TabStop = false;
            // 
            // pctAvion
            // 
            this.pctAvion.BackColor = System.Drawing.Color.Transparent;
            this.pctAvion.Image = global::Guerra_de_Aviones.Properties.Resources.WhatsApp_Image_2021_03_11_at_11_44_50_AM;
            this.pctAvion.Location = new System.Drawing.Point(342, 349);
            this.pctAvion.Name = "pctAvion";
            this.pctAvion.Size = new System.Drawing.Size(100, 89);
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
            // lblIniciar
            // 
            this.lblIniciar.AutoSize = true;
            this.lblIniciar.Location = new System.Drawing.Point(12, 9);
            this.lblIniciar.Name = "lblIniciar";
            this.lblIniciar.Size = new System.Drawing.Size(67, 13);
            this.lblIniciar.TabIndex = 5;
            this.lblIniciar.Text = "Iniciar Juego";
            this.lblIniciar.Click += new System.EventHandler(this.lblIniciar_Click);
            // 
            // tmrTiempojuego
            // 
            this.tmrTiempojuego.Interval = 60;
            this.tmrTiempojuego.Tick += new System.EventHandler(this.tmrTiempojuego_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIniciar);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.pctMisil);
            this.Controls.Add(this.pctAvion);
            this.Controls.Add(this.pctFondo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctMisil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctFondo;
        private System.Windows.Forms.PictureBox pctAvion;
        private System.Windows.Forms.PictureBox pctMisil;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Label lblIniciar;
        private System.Windows.Forms.Timer tmrTiempojuego;
    }
}

