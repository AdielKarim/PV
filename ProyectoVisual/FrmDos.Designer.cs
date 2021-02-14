namespace ProyectoVisual
{
    partial class FrmDos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTipoDeDelito = new System.Windows.Forms.Label();
            this.cmbTipoDeDelito = new System.Windows.Forms.ComboBox();
            this.lblAñoDelito = new System.Windows.Forms.Label();
            this.rdbEsteAño = new System.Windows.Forms.RadioButton();
            this.rdbHaceMasDeDosAños = new System.Windows.Forms.RadioButton();
            this.rdbElAñoPasado = new System.Windows.Forms.RadioButton();
            this.lblLaVictima = new System.Windows.Forms.Label();
            this.rdbHombre = new System.Windows.Forms.RadioButton();
            this.rdbMujer = new System.Windows.Forms.RadioButton();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pnlAñoQueSeCometioDelito = new System.Windows.Forms.Panel();
            this.pnlVictima = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFechadeHoy = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblEdadDeLaVictima = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbMasDeSesentaAños = new System.Windows.Forms.RadioButton();
            this.rdbCincuentaAños = new System.Windows.Forms.RadioButton();
            this.rdbTreintaAños = new System.Windows.Forms.RadioButton();
            this.rdbQuinceAños = new System.Windows.Forms.RadioButton();
            this.rdbSeisAños = new System.Windows.Forms.RadioButton();
            this.prbAumento = new System.Windows.Forms.ProgressBar();
            this.pnlAñoQueSeCometioDelito.SuspendLayout();
            this.pnlVictima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipoDeDelito
            // 
            this.lblTipoDeDelito.AutoSize = true;
            this.lblTipoDeDelito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeDelito.Location = new System.Drawing.Point(13, 97);
            this.lblTipoDeDelito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoDeDelito.Name = "lblTipoDeDelito";
            this.lblTipoDeDelito.Size = new System.Drawing.Size(202, 18);
            this.lblTipoDeDelito.TabIndex = 5;
            this.lblTipoDeDelito.Text = "4. Especifique el tipo de delito";
            // 
            // cmbTipoDeDelito
            // 
            this.cmbTipoDeDelito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDeDelito.FormattingEnabled = true;
            this.cmbTipoDeDelito.Items.AddRange(new object[] {
            "Robo a casa",
            "Robo a persona",
            "Robo a negocio",
            "Robo de auto",
            "Lesiones",
            "Violación",
            "Violencia familiar",
            "Homicidio",
            "Extorisón",
            "Secuestro"});
            this.cmbTipoDeDelito.Location = new System.Drawing.Point(16, 127);
            this.cmbTipoDeDelito.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoDeDelito.Name = "cmbTipoDeDelito";
            this.cmbTipoDeDelito.Size = new System.Drawing.Size(104, 24);
            this.cmbTipoDeDelito.TabIndex = 8;
            this.cmbTipoDeDelito.Text = "Robo a casa";
            // 
            // lblAñoDelito
            // 
            this.lblAñoDelito.AutoSize = true;
            this.lblAñoDelito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñoDelito.Location = new System.Drawing.Point(13, 158);
            this.lblAñoDelito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAñoDelito.Name = "lblAñoDelito";
            this.lblAñoDelito.Size = new System.Drawing.Size(245, 18);
            this.lblAñoDelito.TabIndex = 9;
            this.lblAñoDelito.Text = "5. Año en el que se cometió el delito";
            // 
            // rdbEsteAño
            // 
            this.rdbEsteAño.AutoSize = true;
            this.rdbEsteAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEsteAño.Location = new System.Drawing.Point(2, 2);
            this.rdbEsteAño.Margin = new System.Windows.Forms.Padding(2);
            this.rdbEsteAño.Name = "rdbEsteAño";
            this.rdbEsteAño.Size = new System.Drawing.Size(79, 20);
            this.rdbEsteAño.TabIndex = 10;
            this.rdbEsteAño.TabStop = true;
            this.rdbEsteAño.Text = "Este año";
            this.rdbEsteAño.UseVisualStyleBackColor = true;
            // 
            // rdbHaceMasDeDosAños
            // 
            this.rdbHaceMasDeDosAños.AutoSize = true;
            this.rdbHaceMasDeDosAños.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHaceMasDeDosAños.Location = new System.Drawing.Point(2, 41);
            this.rdbHaceMasDeDosAños.Margin = new System.Windows.Forms.Padding(2);
            this.rdbHaceMasDeDosAños.Name = "rdbHaceMasDeDosAños";
            this.rdbHaceMasDeDosAños.Size = new System.Drawing.Size(166, 20);
            this.rdbHaceMasDeDosAños.TabIndex = 14;
            this.rdbHaceMasDeDosAños.TabStop = true;
            this.rdbHaceMasDeDosAños.Text = "Hace más de dos años";
            this.rdbHaceMasDeDosAños.UseVisualStyleBackColor = true;
            // 
            // rdbElAñoPasado
            // 
            this.rdbElAñoPasado.AutoSize = true;
            this.rdbElAñoPasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbElAñoPasado.Location = new System.Drawing.Point(2, 22);
            this.rdbElAñoPasado.Margin = new System.Windows.Forms.Padding(2);
            this.rdbElAñoPasado.Name = "rdbElAñoPasado";
            this.rdbElAñoPasado.Size = new System.Drawing.Size(114, 20);
            this.rdbElAñoPasado.TabIndex = 15;
            this.rdbElAñoPasado.TabStop = true;
            this.rdbElAñoPasado.Text = "El año pasado";
            this.rdbElAñoPasado.UseVisualStyleBackColor = true;
            // 
            // lblLaVictima
            // 
            this.lblLaVictima.AutoSize = true;
            this.lblLaVictima.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaVictima.Location = new System.Drawing.Point(15, 263);
            this.lblLaVictima.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLaVictima.Name = "lblLaVictima";
            this.lblLaVictima.Size = new System.Drawing.Size(113, 18);
            this.lblLaVictima.TabIndex = 16;
            this.lblLaVictima.Text = "6. La vicitima es";
            // 
            // rdbHombre
            // 
            this.rdbHombre.AutoSize = true;
            this.rdbHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHombre.Location = new System.Drawing.Point(2, 2);
            this.rdbHombre.Margin = new System.Windows.Forms.Padding(2);
            this.rdbHombre.Name = "rdbHombre";
            this.rdbHombre.Size = new System.Drawing.Size(75, 20);
            this.rdbHombre.TabIndex = 17;
            this.rdbHombre.TabStop = true;
            this.rdbHombre.Text = "Hombre";
            this.rdbHombre.UseVisualStyleBackColor = true;
            this.rdbHombre.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbMujer
            // 
            this.rdbMujer.AutoSize = true;
            this.rdbMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMujer.Location = new System.Drawing.Point(2, 25);
            this.rdbMujer.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMujer.Name = "rdbMujer";
            this.rdbMujer.Size = new System.Drawing.Size(59, 20);
            this.rdbMujer.TabIndex = 18;
            this.rdbMujer.TabStop = true;
            this.rdbMujer.Text = "Mujer";
            this.rdbMujer.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(700, 394);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(89, 35);
            this.btnSiguiente.TabIndex = 19;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(580, 394);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(89, 35);
            this.btnAtras.TabIndex = 20;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pnlAñoQueSeCometioDelito
            // 
            this.pnlAñoQueSeCometioDelito.Controls.Add(this.rdbEsteAño);
            this.pnlAñoQueSeCometioDelito.Controls.Add(this.rdbElAñoPasado);
            this.pnlAñoQueSeCometioDelito.Controls.Add(this.rdbHaceMasDeDosAños);
            this.pnlAñoQueSeCometioDelito.Location = new System.Drawing.Point(16, 187);
            this.pnlAñoQueSeCometioDelito.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAñoQueSeCometioDelito.Name = "pnlAñoQueSeCometioDelito";
            this.pnlAñoQueSeCometioDelito.Size = new System.Drawing.Size(168, 65);
            this.pnlAñoQueSeCometioDelito.TabIndex = 23;
            // 
            // pnlVictima
            // 
            this.pnlVictima.Controls.Add(this.rdbHombre);
            this.pnlVictima.Controls.Add(this.rdbMujer);
            this.pnlVictima.Location = new System.Drawing.Point(16, 291);
            this.pnlVictima.Margin = new System.Windows.Forms.Padding(2);
            this.pnlVictima.Name = "pnlVictima";
            this.pnlVictima.Size = new System.Drawing.Size(104, 50);
            this.pnlVictima.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoVisual.Properties.Resources._845eaab6_1665_4fcd_90c6_dd832542c439;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // lblFechadeHoy
            // 
            this.lblFechadeHoy.AutoSize = true;
            this.lblFechadeHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechadeHoy.Location = new System.Drawing.Point(470, 39);
            this.lblFechadeHoy.Name = "lblFechadeHoy";
            this.lblFechadeHoy.Size = new System.Drawing.Size(104, 18);
            this.lblFechadeHoy.TabIndex = 27;
            this.lblFechadeHoy.Text = "Fecha de Hoy:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(580, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // lblEdadDeLaVictima
            // 
            this.lblEdadDeLaVictima.AutoSize = true;
            this.lblEdadDeLaVictima.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdadDeLaVictima.Location = new System.Drawing.Point(15, 351);
            this.lblEdadDeLaVictima.Name = "lblEdadDeLaVictima";
            this.lblEdadDeLaVictima.Size = new System.Drawing.Size(145, 18);
            this.lblEdadDeLaVictima.TabIndex = 28;
            this.lblEdadDeLaVictima.Text = "7. Edad de la Victima";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbMasDeSesentaAños);
            this.panel1.Controls.Add(this.rdbCincuentaAños);
            this.panel1.Controls.Add(this.rdbTreintaAños);
            this.panel1.Controls.Add(this.rdbQuinceAños);
            this.panel1.Controls.Add(this.rdbSeisAños);
            this.panel1.Location = new System.Drawing.Point(12, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 64);
            this.panel1.TabIndex = 29;
            // 
            // rdbMasDeSesentaAños
            // 
            this.rdbMasDeSesentaAños.AutoSize = true;
            this.rdbMasDeSesentaAños.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMasDeSesentaAños.Location = new System.Drawing.Point(232, 26);
            this.rdbMasDeSesentaAños.Name = "rdbMasDeSesentaAños";
            this.rdbMasDeSesentaAños.Size = new System.Drawing.Size(122, 20);
            this.rdbMasDeSesentaAños.TabIndex = 4;
            this.rdbMasDeSesentaAños.TabStop = true;
            this.rdbMasDeSesentaAños.Text = "Mas de 60 Años";
            this.rdbMasDeSesentaAños.UseVisualStyleBackColor = true;
            // 
            // rdbCincuentaAños
            // 
            this.rdbCincuentaAños.AutoSize = true;
            this.rdbCincuentaAños.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCincuentaAños.Location = new System.Drawing.Point(128, 37);
            this.rdbCincuentaAños.Name = "rdbCincuentaAños";
            this.rdbCincuentaAños.Size = new System.Drawing.Size(102, 20);
            this.rdbCincuentaAños.TabIndex = 3;
            this.rdbCincuentaAños.TabStop = true;
            this.rdbCincuentaAños.Text = "31 a 60 Años";
            this.rdbCincuentaAños.UseVisualStyleBackColor = true;
            // 
            // rdbTreintaAños
            // 
            this.rdbTreintaAños.AutoSize = true;
            this.rdbTreintaAños.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTreintaAños.Location = new System.Drawing.Point(128, 11);
            this.rdbTreintaAños.Name = "rdbTreintaAños";
            this.rdbTreintaAños.Size = new System.Drawing.Size(102, 20);
            this.rdbTreintaAños.TabIndex = 2;
            this.rdbTreintaAños.TabStop = true;
            this.rdbTreintaAños.Text = "16 a 30 Años";
            this.rdbTreintaAños.UseVisualStyleBackColor = true;
            // 
            // rdbQuinceAños
            // 
            this.rdbQuinceAños.AutoSize = true;
            this.rdbQuinceAños.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbQuinceAños.Location = new System.Drawing.Point(4, 35);
            this.rdbQuinceAños.Name = "rdbQuinceAños";
            this.rdbQuinceAños.Size = new System.Drawing.Size(95, 20);
            this.rdbQuinceAños.TabIndex = 1;
            this.rdbQuinceAños.TabStop = true;
            this.rdbQuinceAños.Text = "6 a 15 Años";
            this.rdbQuinceAños.UseVisualStyleBackColor = true;
            // 
            // rdbSeisAños
            // 
            this.rdbSeisAños.AutoSize = true;
            this.rdbSeisAños.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSeisAños.Location = new System.Drawing.Point(3, 10);
            this.rdbSeisAños.Name = "rdbSeisAños";
            this.rdbSeisAños.Size = new System.Drawing.Size(119, 20);
            this.rdbSeisAños.TabIndex = 0;
            this.rdbSeisAños.TabStop = true;
            this.rdbSeisAños.Text = "Menor a 6 Años";
            this.rdbSeisAños.UseVisualStyleBackColor = true;
            // 
            // prbAumento
            // 
            this.prbAumento.Location = new System.Drawing.Point(506, 10);
            this.prbAumento.Name = "prbAumento";
            this.prbAumento.Size = new System.Drawing.Size(282, 23);
            this.prbAumento.TabIndex = 30;
            // 
            // FrmDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prbAumento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEdadDeLaVictima);
            this.Controls.Add(this.lblFechadeHoy);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlVictima);
            this.Controls.Add(this.pnlAñoQueSeCometioDelito);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblLaVictima);
            this.Controls.Add(this.lblAñoDelito);
            this.Controls.Add(this.cmbTipoDeDelito);
            this.Controls.Add(this.lblTipoDeDelito);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDos";
            this.Text = "FrmDos";
            this.pnlAñoQueSeCometioDelito.ResumeLayout(false);
            this.pnlAñoQueSeCometioDelito.PerformLayout();
            this.pnlVictima.ResumeLayout(false);
            this.pnlVictima.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTipoDeDelito;
        private System.Windows.Forms.ComboBox cmbTipoDeDelito;
        private System.Windows.Forms.Label lblAñoDelito;
        private System.Windows.Forms.RadioButton rdbEsteAño;
        private System.Windows.Forms.RadioButton rdbHaceMasDeDosAños;
        private System.Windows.Forms.RadioButton rdbElAñoPasado;
        private System.Windows.Forms.Label lblLaVictima;
        private System.Windows.Forms.RadioButton rdbHombre;
        private System.Windows.Forms.RadioButton rdbMujer;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Panel pnlAñoQueSeCometioDelito;
        private System.Windows.Forms.Panel pnlVictima;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFechadeHoy;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblEdadDeLaVictima;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbMasDeSesentaAños;
        private System.Windows.Forms.RadioButton rdbCincuentaAños;
        private System.Windows.Forms.RadioButton rdbTreintaAños;
        private System.Windows.Forms.RadioButton rdbQuinceAños;
        private System.Windows.Forms.RadioButton rdbSeisAños;
        private System.Windows.Forms.ProgressBar prbAumento;
    }
}