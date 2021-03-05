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
            this.grpLevel = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctPlayer = new System.Windows.Forms.PictureBox();
            this.pctEnemy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trcVelocidad)).BeginInit();
            this.grpLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEnemy)).BeginInit();
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
            this.trcVelocidad.Location = new System.Drawing.Point(744, 497);
            this.trcVelocidad.Minimum = 1;
            this.trcVelocidad.Name = "trcVelocidad";
            this.trcVelocidad.Size = new System.Drawing.Size(212, 45);
            this.trcVelocidad.TabIndex = 6;
            this.trcVelocidad.Value = 10;
            this.trcVelocidad.Scroll += new System.EventHandler(this.trcVelocidad_Scroll);
            // 
            // grpLevel
            // 
            this.grpLevel.Controls.Add(this.pictureBox3);
            this.grpLevel.Controls.Add(this.pictureBox2);
            this.grpLevel.Controls.Add(this.pictureBox1);
            this.grpLevel.Controls.Add(this.pctPlayer);
            this.grpLevel.Controls.Add(this.pctEnemy);
            this.grpLevel.Location = new System.Drawing.Point(12, 12);
            this.grpLevel.Name = "grpLevel";
            this.grpLevel.Size = new System.Drawing.Size(686, 620);
            this.grpLevel.TabIndex = 8;
            this.grpLevel.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Juego.Properties.Resources.descarga_azul;
            this.pictureBox3.Location = new System.Drawing.Point(285, 369);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 109);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Juego.Properties.Resources.descarga_red;
            this.pictureBox2.Location = new System.Drawing.Point(351, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Juego.Properties.Resources.descarga_negro;
            this.pictureBox1.Location = new System.Drawing.Point(94, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pctPlayer
            // 
            this.pctPlayer.Image = global::Juego.Properties.Resources.descarga;
            this.pctPlayer.Location = new System.Drawing.Point(145, 57);
            this.pctPlayer.Name = "pctPlayer";
            this.pctPlayer.Size = new System.Drawing.Size(131, 109);
            this.pctPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPlayer.TabIndex = 0;
            this.pctPlayer.TabStop = false;
            // 
            // pctEnemy
            // 
            this.pctEnemy.Image = global::Juego.Properties.Resources._0f05aa6517e9acc80aefcfa701845fc5;
            this.pctEnemy.Location = new System.Drawing.Point(415, 223);
            this.pctEnemy.Name = "pctEnemy";
            this.pctEnemy.Size = new System.Drawing.Size(139, 109);
            this.pctEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEnemy.TabIndex = 7;
            this.pctEnemy.TabStop = false;
            // 
            // frmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 644);
            this.Controls.Add(this.grpLevel);
            this.Controls.Add(this.trcVelocidad);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnArriba);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnDerecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmJuego";
            this.Load += new System.EventHandler(this.frmJuego_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmJuego_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.trcVelocidad)).EndInit();
            this.grpLevel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEnemy)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

