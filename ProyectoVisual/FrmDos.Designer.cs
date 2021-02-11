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
            this.lblUstedViveEn = new System.Windows.Forms.Label();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.lblVictima = new System.Windows.Forms.Label();
            this.lblTipoDeDelito = new System.Windows.Forms.Label();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.rdbNo = new System.Windows.Forms.RadioButton();
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
            this.pnlSiNo = new System.Windows.Forms.Panel();
            this.pnlAñoQueSeCometioDelito = new System.Windows.Forms.Panel();
            this.pnlVictima = new System.Windows.Forms.Panel();
            this.pnlSiNo.SuspendLayout();
            this.pnlAñoQueSeCometioDelito.SuspendLayout();
            this.pnlVictima.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUstedViveEn
            // 
            this.lblUstedViveEn.AutoSize = true;
            this.lblUstedViveEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUstedViveEn.Location = new System.Drawing.Point(21, 39);
            this.lblUstedViveEn.Name = "lblUstedViveEn";
            this.lblUstedViveEn.Size = new System.Drawing.Size(134, 24);
            this.lblUstedViveEn.TabIndex = 0;
            this.lblUstedViveEn.Text = "Usted Vive En:";
            // 
            // cmbEstados
            // 
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Items.AddRange(new object[] {
            "Aguascalientes",
            "Baja California",
            "Baja California Sur",
            "Campeche",
            "Coahuila",
            "Colima",
            "Chiapas",
            "Chihuahua",
            "Distrito Federal",
            "Durango",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "Estado de México",
            "Michoacán",
            "Morelos",
            "Nayarit",
            "Nuevo León",
            "Oaxaca",
            "Puebla",
            "Queretaro",
            "Quintana Roo",
            "San Luis Potosi",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz",
            "Yucatán",
            "Zacatecas"});
            this.cmbEstados.Location = new System.Drawing.Point(161, 39);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(121, 24);
            this.cmbEstados.TabIndex = 1;
            this.cmbEstados.Text = "Aguascalientes";
            this.cmbEstados.SelectedIndexChanged += new System.EventHandler(this.cmbEstados_SelectedIndexChanged);
            // 
            // lblVictima
            // 
            this.lblVictima.AutoSize = true;
            this.lblVictima.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVictima.Location = new System.Drawing.Point(20, 72);
            this.lblVictima.Name = "lblVictima";
            this.lblVictima.Size = new System.Drawing.Size(714, 24);
            this.lblVictima.TabIndex = 2;
            this.lblVictima.Text = "Este año ¿Usted o algun familiar o conocido ha sido victima de un delito en Méxic" +
    "o?";
            // 
            // lblTipoDeDelito
            // 
            this.lblTipoDeDelito.AutoSize = true;
            this.lblTipoDeDelito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeDelito.Location = new System.Drawing.Point(21, 164);
            this.lblTipoDeDelito.Name = "lblTipoDeDelito";
            this.lblTipoDeDelito.Size = new System.Drawing.Size(241, 24);
            this.lblTipoDeDelito.TabIndex = 5;
            this.lblTipoDeDelito.Text = "Especifique el tipo de delito";
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSi.Location = new System.Drawing.Point(6, 3);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(42, 22);
            this.rdbSi.TabIndex = 6;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "Si";
            this.rdbSi.UseVisualStyleBackColor = true;
            this.rdbSi.CheckedChanged += new System.EventHandler(this.rdbSi_CheckedChanged);
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNo.Location = new System.Drawing.Point(6, 31);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(49, 22);
            this.rdbNo.TabIndex = 7;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // cmbTipoDeDelito
            // 
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
            this.cmbTipoDeDelito.Location = new System.Drawing.Point(24, 193);
            this.cmbTipoDeDelito.Name = "cmbTipoDeDelito";
            this.cmbTipoDeDelito.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoDeDelito.TabIndex = 8;
            this.cmbTipoDeDelito.Text = "Robo a casa";
            // 
            // lblAñoDelito
            // 
            this.lblAñoDelito.AutoSize = true;
            this.lblAñoDelito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñoDelito.Location = new System.Drawing.Point(21, 229);
            this.lblAñoDelito.Name = "lblAñoDelito";
            this.lblAñoDelito.Size = new System.Drawing.Size(297, 24);
            this.lblAñoDelito.TabIndex = 9;
            this.lblAñoDelito.Text = "Año en el que se cometió el delito";
            // 
            // rdbEsteAño
            // 
            this.rdbEsteAño.AutoSize = true;
            this.rdbEsteAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEsteAño.Location = new System.Drawing.Point(3, 3);
            this.rdbEsteAño.Name = "rdbEsteAño";
            this.rdbEsteAño.Size = new System.Drawing.Size(88, 22);
            this.rdbEsteAño.TabIndex = 10;
            this.rdbEsteAño.TabStop = true;
            this.rdbEsteAño.Text = "Este año";
            this.rdbEsteAño.UseVisualStyleBackColor = true;
            // 
            // rdbHaceMasDeDosAños
            // 
            this.rdbHaceMasDeDosAños.AutoSize = true;
            this.rdbHaceMasDeDosAños.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHaceMasDeDosAños.Location = new System.Drawing.Point(3, 51);
            this.rdbHaceMasDeDosAños.Name = "rdbHaceMasDeDosAños";
            this.rdbHaceMasDeDosAños.Size = new System.Drawing.Size(183, 22);
            this.rdbHaceMasDeDosAños.TabIndex = 14;
            this.rdbHaceMasDeDosAños.TabStop = true;
            this.rdbHaceMasDeDosAños.Text = "Hace más de dos años";
            this.rdbHaceMasDeDosAños.UseVisualStyleBackColor = true;
            // 
            // rdbElAñoPasado
            // 
            this.rdbElAñoPasado.AutoSize = true;
            this.rdbElAñoPasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbElAñoPasado.Location = new System.Drawing.Point(3, 27);
            this.rdbElAñoPasado.Name = "rdbElAñoPasado";
            this.rdbElAñoPasado.Size = new System.Drawing.Size(124, 22);
            this.rdbElAñoPasado.TabIndex = 15;
            this.rdbElAñoPasado.TabStop = true;
            this.rdbElAñoPasado.Text = "El año pasado";
            this.rdbElAñoPasado.UseVisualStyleBackColor = true;
            // 
            // lblLaVictima
            // 
            this.lblLaVictima.AutoSize = true;
            this.lblLaVictima.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaVictima.Location = new System.Drawing.Point(21, 349);
            this.lblLaVictima.Name = "lblLaVictima";
            this.lblLaVictima.Size = new System.Drawing.Size(121, 24);
            this.lblLaVictima.TabIndex = 16;
            this.lblLaVictima.Text = "La vicitima es";
            // 
            // rdbHombre
            // 
            this.rdbHombre.AutoSize = true;
            this.rdbHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHombre.Location = new System.Drawing.Point(3, 3);
            this.rdbHombre.Name = "rdbHombre";
            this.rdbHombre.Size = new System.Drawing.Size(83, 22);
            this.rdbHombre.TabIndex = 17;
            this.rdbHombre.TabStop = true;
            this.rdbHombre.Text = "Hombre";
            this.rdbHombre.UseVisualStyleBackColor = true;
            this.rdbHombre.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbMujer
            // 
            this.rdbMujer.AutoSize = true;
            this.rdbMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMujer.Location = new System.Drawing.Point(3, 31);
            this.rdbMujer.Name = "rdbMujer";
            this.rdbMujer.Size = new System.Drawing.Size(66, 22);
            this.rdbMujer.TabIndex = 18;
            this.rdbMujer.TabStop = true;
            this.rdbMujer.Text = "Mujer";
            this.rdbMujer.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(695, 396);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(93, 42);
            this.btnSiguiente.TabIndex = 19;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(584, 396);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(93, 42);
            this.btnAtras.TabIndex = 20;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pnlSiNo
            // 
            this.pnlSiNo.Controls.Add(this.rdbNo);
            this.pnlSiNo.Controls.Add(this.rdbSi);
            this.pnlSiNo.Location = new System.Drawing.Point(25, 101);
            this.pnlSiNo.Name = "pnlSiNo";
            this.pnlSiNo.Size = new System.Drawing.Size(147, 60);
            this.pnlSiNo.TabIndex = 22;
            // 
            // pnlAñoQueSeCometioDelito
            // 
            this.pnlAñoQueSeCometioDelito.Controls.Add(this.rdbEsteAño);
            this.pnlAñoQueSeCometioDelito.Controls.Add(this.rdbElAñoPasado);
            this.pnlAñoQueSeCometioDelito.Controls.Add(this.rdbHaceMasDeDosAños);
            this.pnlAñoQueSeCometioDelito.Location = new System.Drawing.Point(25, 264);
            this.pnlAñoQueSeCometioDelito.Name = "pnlAñoQueSeCometioDelito";
            this.pnlAñoQueSeCometioDelito.Size = new System.Drawing.Size(183, 76);
            this.pnlAñoQueSeCometioDelito.TabIndex = 23;
            // 
            // pnlVictima
            // 
            this.pnlVictima.Controls.Add(this.rdbHombre);
            this.pnlVictima.Controls.Add(this.rdbMujer);
            this.pnlVictima.Location = new System.Drawing.Point(25, 376);
            this.pnlVictima.Name = "pnlVictima";
            this.pnlVictima.Size = new System.Drawing.Size(138, 67);
            this.pnlVictima.TabIndex = 24;
            // 
            // FrmDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlVictima);
            this.Controls.Add(this.pnlAñoQueSeCometioDelito);
            this.Controls.Add(this.pnlSiNo);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblLaVictima);
            this.Controls.Add(this.lblAñoDelito);
            this.Controls.Add(this.cmbTipoDeDelito);
            this.Controls.Add(this.lblTipoDeDelito);
            this.Controls.Add(this.lblVictima);
            this.Controls.Add(this.cmbEstados);
            this.Controls.Add(this.lblUstedViveEn);
            this.Name = "FrmDos";
            this.Text = "FrmDos";
            this.pnlSiNo.ResumeLayout(false);
            this.pnlSiNo.PerformLayout();
            this.pnlAñoQueSeCometioDelito.ResumeLayout(false);
            this.pnlAñoQueSeCometioDelito.PerformLayout();
            this.pnlVictima.ResumeLayout(false);
            this.pnlVictima.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUstedViveEn;
        private System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.Label lblVictima;
        private System.Windows.Forms.Label lblTipoDeDelito;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.RadioButton rdbNo;
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
        private System.Windows.Forms.Panel pnlSiNo;
        private System.Windows.Forms.Panel pnlAñoQueSeCometioDelito;
        private System.Windows.Forms.Panel pnlVictima;
    }
}