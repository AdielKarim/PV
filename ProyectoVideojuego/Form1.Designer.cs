namespace ProyectoVideojuego
{
    partial class frmUno
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
            this.pctCarro1 = new System.Windows.Forms.PictureBox();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctCarro1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctCarro1
            // 
            this.pctCarro1.BackColor = System.Drawing.Color.Transparent;
            this.pctCarro1.Image = global::ProyectoVideojuego.Properties.Resources._803_8030690_aston_martin_one77_17_top_down_car_sprite__1_;
            this.pctCarro1.Location = new System.Drawing.Point(88, 327);
            this.pctCarro1.Name = "pctCarro1";
            this.pctCarro1.Size = new System.Drawing.Size(65, 81);
            this.pctCarro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCarro1.TabIndex = 0;
            this.pctCarro1.TabStop = false;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Location = new System.Drawing.Point(12, 9);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(35, 13);
            this.lblPuntos.TabIndex = 1;
            this.lblPuntos.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProyectoVideojuego.Properties.Resources.Carretera__3_;
            this.ClientSize = new System.Drawing.Size(234, 420);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.pctCarro1);
            this.MaximumSize = new System.Drawing.Size(250, 459);
            this.MinimumSize = new System.Drawing.Size(250, 459);
            this.Name = "frmUno";
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctCarro1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctCarro1;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

