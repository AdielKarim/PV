namespace Juego
{
    partial class frmJuego
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
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnArriba = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.trcVelocidad = new System.Windows.Forms.TrackBar();
            this.pctEnemy = new System.Windows.Forms.PictureBox();
            this.pctPlayer = new System.Windows.Forms.PictureBox();
            this.grpLevel = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.trcVelocidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).BeginInit();
            this.grpLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(891, 589);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 1;
            this.btnDerecha.Text = "Derecha";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(729, 589);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierda.TabIndex = 2;
            this.btnIzquierda.Text = "Izquierda";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnArriba
            // 
            this.btnArriba.Location = new System.Drawing.Point(810, 560);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(75, 23);
            this.btnArriba.TabIndex = 3;
            this.btnArriba.Text = "Arriba";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // btnAbajo
            // 
            this.btnAbajo.Location = new System.Drawing.Point(810, 589);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(75, 23);
            this.btnAbajo.TabIndex = 4;
            this.btnAbajo.Text = "Abajo";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnAbajo_Click);
            // 
            // trcVelocidad
            // 
            this.trcVelocidad.Location = new System.Drawing.Point(737, 143);
            this.trcVelocidad.Minimum = 1;
            this.trcVelocidad.Name = "trcVelocidad";
            this.trcVelocidad.Size = new System.Drawing.Size(212, 45);
            this.trcVelocidad.TabIndex = 6;
            this.trcVelocidad.Value = 10;
            this.trcVelocidad.Scroll += new System.EventHandler(this.trcVelocidad_Scroll);
            // 
            // pctEnemy
            // 
            this.pctEnemy.Image = global::Juego.Properties.Resources._0f05aa6517e9acc80aefcfa701845fc5;
            this.pctEnemy.Location = new System.Drawing.Point(771, 12);
            this.pctEnemy.Name = "pctEnemy";
            this.pctEnemy.Size = new System.Drawing.Size(139, 109);
            this.pctEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEnemy.TabIndex = 7;
            this.pctEnemy.TabStop = false;
            // 
            // pctPlayer
            // 
            this.pctPlayer.Image = global::Juego.Properties.Resources.descarga;
            this.pctPlayer.Location = new System.Drawing.Point(66, 19);
            this.pctPlayer.Name = "pctPlayer";
            this.pctPlayer.Size = new System.Drawing.Size(131, 109);
            this.pctPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPlayer.TabIndex = 0;
            this.pctPlayer.TabStop = false;
            // 
            // grpLevel
            // 
            this.grpLevel.Controls.Add(this.pctPlayer);
            this.grpLevel.Location = new System.Drawing.Point(12, 12);
            this.grpLevel.Name = "grpLevel";
            this.grpLevel.Size = new System.Drawing.Size(686, 620);
            this.grpLevel.TabIndex = 8;
            this.grpLevel.TabStop = false;
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 644);
            this.Controls.Add(this.grpLevel);
            this.Controls.Add(this.pctEnemy);
            this.Controls.Add(this.trcVelocidad);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnArriba);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnDerecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmJuego";
            this.Text = "Juego";
            ((System.ComponentModel.ISupportInitialize)(this.trcVelocidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).EndInit();
            this.grpLevel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctPlayer;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.TrackBar trcVelocidad;
        private System.Windows.Forms.PictureBox pctEnemy;
        private System.Windows.Forms.GroupBox grpLevel;
    }
}

