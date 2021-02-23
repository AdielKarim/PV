namespace ProyectoVisual
{
    partial class frmVentanaCuatro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentanaCuatro));
            this.lblAuxilioALaPolicia = new System.Windows.Forms.Label();
            this.lblFechadeHoy = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.rdbMuyBien = new System.Windows.Forms.RadioButton();
            this.rdbBien = new System.Windows.Forms.RadioButton();
            this.rdbMal = new System.Windows.Forms.RadioButton();
            this.rbdMuyMal = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prbAumento = new System.Windows.Forms.ProgressBar();
            this.lblSinoPidioAuxilio = new System.Windows.Forms.Label();
            this.cmbPorqueNoLoHizo = new System.Windows.Forms.ComboBox();
            this.lblDenuncioElDelito = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rbdSi = new System.Windows.Forms.RadioButton();
            this.lblNoLoDenuncio = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblOtra = new System.Windows.Forms.Label();
            this.txtRespuestaAMinesterio = new System.Windows.Forms.TextBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAuxilioALaPolicia
            // 
            this.lblAuxilioALaPolicia.AutoSize = true;
            this.lblAuxilioALaPolicia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuxilioALaPolicia.Location = new System.Drawing.Point(12, 85);
            this.lblAuxilioALaPolicia.Name = "lblAuxilioALaPolicia";
            this.lblAuxilioALaPolicia.Size = new System.Drawing.Size(397, 18);
            this.lblAuxilioALaPolicia.TabIndex = 3;
            this.lblAuxilioALaPolicia.Text = "11. En caso afirmativo que si haya pedido ayuda a la policia";
            // 
            // lblFechadeHoy
            // 
            this.lblFechadeHoy.AutoSize = true;
            this.lblFechadeHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechadeHoy.Location = new System.Drawing.Point(470, 39);
            this.lblFechadeHoy.Name = "lblFechadeHoy";
            this.lblFechadeHoy.Size = new System.Drawing.Size(104, 18);
            this.lblFechadeHoy.TabIndex = 32;
            this.lblFechadeHoy.Text = "Fecha de Hoy:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(580, 39);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(208, 20);
            this.dtpFecha.TabIndex = 31;
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion.Location = new System.Drawing.Point(12, 112);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(254, 18);
            this.lblCalificacion.TabIndex = 33;
            this.lblCalificacion.Text = "¿Como califica la ayuda de la policia?";
            // 
            // rdbMuyBien
            // 
            this.rdbMuyBien.AutoSize = true;
            this.rdbMuyBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMuyBien.Location = new System.Drawing.Point(3, 9);
            this.rdbMuyBien.Name = "rdbMuyBien";
            this.rdbMuyBien.Size = new System.Drawing.Size(81, 20);
            this.rdbMuyBien.TabIndex = 34;
            this.rdbMuyBien.TabStop = true;
            this.rdbMuyBien.Text = "Muy Bien";
            this.rdbMuyBien.UseVisualStyleBackColor = true;
            // 
            // rdbBien
            // 
            this.rdbBien.AutoSize = true;
            this.rdbBien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBien.Location = new System.Drawing.Point(90, 9);
            this.rdbBien.Name = "rdbBien";
            this.rdbBien.Size = new System.Drawing.Size(53, 20);
            this.rdbBien.TabIndex = 35;
            this.rdbBien.TabStop = true;
            this.rdbBien.Text = "Bien";
            this.rdbBien.UseVisualStyleBackColor = true;
            // 
            // rdbMal
            // 
            this.rdbMal.AutoSize = true;
            this.rdbMal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMal.Location = new System.Drawing.Point(149, 9);
            this.rdbMal.Name = "rdbMal";
            this.rdbMal.Size = new System.Drawing.Size(48, 20);
            this.rdbMal.TabIndex = 36;
            this.rdbMal.TabStop = true;
            this.rdbMal.Text = "Mal";
            this.rdbMal.UseVisualStyleBackColor = true;
            // 
            // rbdMuyMal
            // 
            this.rbdMuyMal.AutoSize = true;
            this.rbdMuyMal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdMuyMal.Location = new System.Drawing.Point(203, 9);
            this.rbdMuyMal.Name = "rbdMuyMal";
            this.rbdMuyMal.Size = new System.Drawing.Size(76, 20);
            this.rbdMuyMal.TabIndex = 37;
            this.rbdMuyMal.TabStop = true;
            this.rbdMuyMal.Text = "Muy Mal";
            this.rbdMuyMal.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.rdbMuyBien);
            this.panel1.Controls.Add(this.rbdMuyMal);
            this.panel1.Controls.Add(this.rdbMal);
            this.panel1.Controls.Add(this.rdbBien);
            this.panel1.Location = new System.Drawing.Point(15, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 36);
            this.panel1.TabIndex = 38;
            // 
            // prbAumento
            // 
            this.prbAumento.Location = new System.Drawing.Point(506, 10);
            this.prbAumento.Name = "prbAumento";
            this.prbAumento.Size = new System.Drawing.Size(282, 23);
            this.prbAumento.TabIndex = 39;
            this.prbAumento.Click += new System.EventHandler(this.prbAumento_Click);
            // 
            // lblSinoPidioAuxilio
            // 
            this.lblSinoPidioAuxilio.AutoSize = true;
            this.lblSinoPidioAuxilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinoPidioAuxilio.Location = new System.Drawing.Point(12, 175);
            this.lblSinoPidioAuxilio.Name = "lblSinoPidioAuxilio";
            this.lblSinoPidioAuxilio.Size = new System.Drawing.Size(457, 18);
            this.lblSinoPidioAuxilio.TabIndex = 40;
            this.lblSinoPidioAuxilio.Text = "12. Si NO pidió auxilio a la Policía Preventiva, diga porqué no lo hizo:";
            // 
            // cmbPorqueNoLoHizo
            // 
            this.cmbPorqueNoLoHizo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPorqueNoLoHizo.FormattingEnabled = true;
            this.cmbPorqueNoLoHizo.Items.AddRange(new object[] {
            "Porque el delito era de poca importancia.",
            "Porque no sé como hacerlo.",
            "Porque pensé que la policía no haría nada.",
            "Porque no tengo confianza en la policía preventiva.",
            "Porque me amenazaron.",
            "Por miedo al agresor.",
            "Porque mi familia no quiso.",
            "Por vergüenza."});
            this.cmbPorqueNoLoHizo.Location = new System.Drawing.Point(15, 200);
            this.cmbPorqueNoLoHizo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPorqueNoLoHizo.Name = "cmbPorqueNoLoHizo";
            this.cmbPorqueNoLoHizo.Size = new System.Drawing.Size(340, 24);
            this.cmbPorqueNoLoHizo.TabIndex = 41;
            this.cmbPorqueNoLoHizo.Text = "Porque el delito era de poca importancia.";
            // 
            // lblDenuncioElDelito
            // 
            this.lblDenuncioElDelito.AutoSize = true;
            this.lblDenuncioElDelito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenuncioElDelito.Location = new System.Drawing.Point(12, 230);
            this.lblDenuncioElDelito.Name = "lblDenuncioElDelito";
            this.lblDenuncioElDelito.Size = new System.Drawing.Size(485, 18);
            this.lblDenuncioElDelito.TabIndex = 42;
            this.lblDenuncioElDelito.Text = "13. ¿Denunció el delito ante el Ministerio Público (Procuraduría Estatal)? ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.rdbNo);
            this.panel2.Controls.Add(this.rbdSi);
            this.panel2.Location = new System.Drawing.Point(15, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 55);
            this.panel2.TabIndex = 43;
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNo.Location = new System.Drawing.Point(3, 32);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(44, 20);
            this.rdbNo.TabIndex = 44;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rbdSi
            // 
            this.rbdSi.AutoSize = true;
            this.rbdSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdSi.Location = new System.Drawing.Point(3, 9);
            this.rbdSi.Name = "rbdSi";
            this.rbdSi.Size = new System.Drawing.Size(38, 20);
            this.rbdSi.TabIndex = 34;
            this.rbdSi.TabStop = true;
            this.rbdSi.Text = "Si";
            this.rbdSi.UseVisualStyleBackColor = true;
            // 
            // lblNoLoDenuncio
            // 
            this.lblNoLoDenuncio.AutoSize = true;
            this.lblNoLoDenuncio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoLoDenuncio.Location = new System.Drawing.Point(12, 318);
            this.lblNoLoDenuncio.Name = "lblNoLoDenuncio";
            this.lblNoLoDenuncio.Size = new System.Drawing.Size(310, 18);
            this.lblNoLoDenuncio.TabIndex = 44;
            this.lblNoLoDenuncio.Text = " 14. Si NO lo denunció diga porque no lo hizo:";
            this.lblNoLoDenuncio.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Porque no tenia importancia",
            "Porque no sé como hacerlo",
            "Porque pensé que no harían nada",
            "Porque son trámites largos y difíciles",
            "Por miedo al agresor",
            "Porque la familia no quiso",
            "Porque me amenazaron",
            "Porque desconfio de la autoridad",
            "Por vergüenza"});
            this.comboBox1.Location = new System.Drawing.Point(15, 344);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 24);
            this.comboBox1.TabIndex = 45;
            this.comboBox1.Text = "Porque no tenia importancia";
            // 
            // lblOtra
            // 
            this.lblOtra.AutoSize = true;
            this.lblOtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtra.Location = new System.Drawing.Point(15, 380);
            this.lblOtra.Name = "lblOtra";
            this.lblOtra.Size = new System.Drawing.Size(114, 16);
            this.lblOtra.TabIndex = 46;
            this.lblOtra.Text = "Otra (especifique)";
            // 
            // txtRespuestaAMinesterio
            // 
            this.txtRespuestaAMinesterio.Location = new System.Drawing.Point(18, 402);
            this.txtRespuestaAMinesterio.Name = "txtRespuestaAMinesterio";
            this.txtRespuestaAMinesterio.Size = new System.Drawing.Size(284, 20);
            this.txtRespuestaAMinesterio.TabIndex = 47;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(701, 405);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(89, 35);
            this.btnSiguiente.TabIndex = 48;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(606, 405);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(89, 35);
            this.btnAtras.TabIndex = 49;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoVisual.Properties.Resources._845eaab6_1665_4fcd_90c6_dd832542c439;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // frmVentanaCuatro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtRespuestaAMinesterio);
            this.Controls.Add(this.lblOtra);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblNoLoDenuncio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblDenuncioElDelito);
            this.Controls.Add(this.cmbPorqueNoLoHizo);
            this.Controls.Add(this.lblSinoPidioAuxilio);
            this.Controls.Add(this.prbAumento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.lblFechadeHoy);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAuxilioALaPolicia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentanaCuatro";
            this.Text = "Formulario de Inseguridad";
            this.Load += new System.EventHandler(this.FrmCuatro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuxilioALaPolicia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFechadeHoy;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.RadioButton rdbMuyBien;
        private System.Windows.Forms.RadioButton rdbBien;
        private System.Windows.Forms.RadioButton rdbMal;
        private System.Windows.Forms.RadioButton rbdMuyMal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar prbAumento;
        private System.Windows.Forms.Label lblSinoPidioAuxilio;
        private System.Windows.Forms.ComboBox cmbPorqueNoLoHizo;
        private System.Windows.Forms.Label lblDenuncioElDelito;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rbdSi;
        private System.Windows.Forms.Label lblNoLoDenuncio;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblOtra;
        private System.Windows.Forms.TextBox txtRespuestaAMinesterio;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAtras;
    }
}