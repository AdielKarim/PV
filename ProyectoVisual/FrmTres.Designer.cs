namespace ProyectoVisual
{
    partial class FrmTres
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
            this.lblAgresoroDelincuente = new System.Windows.Forms.Label();
            this.rdbDesconocido = new System.Windows.Forms.RadioButton();
            this.rdbConocido = new System.Windows.Forms.RadioButton();
            this.rdbPariente = new System.Windows.Forms.RadioButton();
            this.rdbAmigo = new System.Windows.Forms.RadioButton();
            this.rdbVecino = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSeleccionaEstado = new System.Windows.Forms.Label();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.lblAuxilio = new System.Windows.Forms.Label();
            this.pnlSiNo = new System.Windows.Forms.Panel();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.lblOtraAutoridad = new System.Windows.Forms.Label();
            this.txtRespuestaAutoridad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFechadeHoy = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAtras = new System.Windows.Forms.Button();
            this.Siguientes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlSiNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgresoroDelincuente
            // 
            this.lblAgresoroDelincuente.AutoSize = true;
            this.lblAgresoroDelincuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgresoroDelincuente.Location = new System.Drawing.Point(16, 85);
            this.lblAgresoroDelincuente.Name = "lblAgresoroDelincuente";
            this.lblAgresoroDelincuente.Size = new System.Drawing.Size(207, 18);
            this.lblAgresoroDelincuente.TabIndex = 0;
            this.lblAgresoroDelincuente.Text = "8. El Agresor o Delincuente es";
            // 
            // rdbDesconocido
            // 
            this.rdbDesconocido.AutoSize = true;
            this.rdbDesconocido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDesconocido.Location = new System.Drawing.Point(12, 12);
            this.rdbDesconocido.Name = "rdbDesconocido";
            this.rdbDesconocido.Size = new System.Drawing.Size(107, 20);
            this.rdbDesconocido.TabIndex = 0;
            this.rdbDesconocido.TabStop = true;
            this.rdbDesconocido.Text = "Desconocido";
            this.rdbDesconocido.UseVisualStyleBackColor = true;
            // 
            // rdbConocido
            // 
            this.rdbConocido.AutoSize = true;
            this.rdbConocido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbConocido.Location = new System.Drawing.Point(12, 38);
            this.rdbConocido.Name = "rdbConocido";
            this.rdbConocido.Size = new System.Drawing.Size(84, 20);
            this.rdbConocido.TabIndex = 1;
            this.rdbConocido.TabStop = true;
            this.rdbConocido.Text = "Conocido";
            this.rdbConocido.UseVisualStyleBackColor = true;
            // 
            // rdbPariente
            // 
            this.rdbPariente.AutoSize = true;
            this.rdbPariente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPariente.Location = new System.Drawing.Point(12, 58);
            this.rdbPariente.Name = "rdbPariente";
            this.rdbPariente.Size = new System.Drawing.Size(76, 20);
            this.rdbPariente.TabIndex = 2;
            this.rdbPariente.TabStop = true;
            this.rdbPariente.Text = "Pariente";
            this.rdbPariente.UseVisualStyleBackColor = true;
            // 
            // rdbAmigo
            // 
            this.rdbAmigo.AutoSize = true;
            this.rdbAmigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAmigo.Location = new System.Drawing.Point(12, 81);
            this.rdbAmigo.Name = "rdbAmigo";
            this.rdbAmigo.Size = new System.Drawing.Size(65, 20);
            this.rdbAmigo.TabIndex = 3;
            this.rdbAmigo.TabStop = true;
            this.rdbAmigo.Text = "Amigo";
            this.rdbAmigo.UseVisualStyleBackColor = true;
            // 
            // rdbVecino
            // 
            this.rdbVecino.AutoSize = true;
            this.rdbVecino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVecino.Location = new System.Drawing.Point(12, 106);
            this.rdbVecino.Name = "rdbVecino";
            this.rdbVecino.Size = new System.Drawing.Size(68, 20);
            this.rdbVecino.TabIndex = 4;
            this.rdbVecino.TabStop = true;
            this.rdbVecino.Text = "Vecino";
            this.rdbVecino.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbVecino);
            this.panel1.Controls.Add(this.rdbAmigo);
            this.panel1.Controls.Add(this.rdbPariente);
            this.panel1.Controls.Add(this.rdbConocido);
            this.panel1.Controls.Add(this.rdbDesconocido);
            this.panel1.Location = new System.Drawing.Point(19, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 130);
            this.panel1.TabIndex = 1;
            // 
            // lblSeleccionaEstado
            // 
            this.lblSeleccionaEstado.AutoSize = true;
            this.lblSeleccionaEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionaEstado.Location = new System.Drawing.Point(16, 244);
            this.lblSeleccionaEstado.Name = "lblSeleccionaEstado";
            this.lblSeleccionaEstado.Size = new System.Drawing.Size(340, 18);
            this.lblSeleccionaEstado.TabIndex = 2;
            this.lblSeleccionaEstado.Text = "9. Selecciona el Estado donde se cometio el delito";
            // 
            // cmbEstados
            // 
            this.cmbEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbEstados.Location = new System.Drawing.Point(19, 264);
            this.cmbEstados.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(118, 24);
            this.cmbEstados.TabIndex = 21;
            this.cmbEstados.Text = "Aguascalientes";
            // 
            // lblAuxilio
            // 
            this.lblAuxilio.AutoSize = true;
            this.lblAuxilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuxilio.Location = new System.Drawing.Point(12, 297);
            this.lblAuxilio.Name = "lblAuxilio";
            this.lblAuxilio.Size = new System.Drawing.Size(242, 18);
            this.lblAuxilio.TabIndex = 22;
            this.lblAuxilio.Text = "10. Pidio Auxilio a la Policia o al 066";
            // 
            // pnlSiNo
            // 
            this.pnlSiNo.Controls.Add(this.rdbNo);
            this.pnlSiNo.Controls.Add(this.rdbSi);
            this.pnlSiNo.Location = new System.Drawing.Point(19, 317);
            this.pnlSiNo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSiNo.Name = "pnlSiNo";
            this.pnlSiNo.Size = new System.Drawing.Size(110, 50);
            this.pnlSiNo.TabIndex = 24;
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNo.Location = new System.Drawing.Point(4, 25);
            this.rdbNo.Margin = new System.Windows.Forms.Padding(2);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(44, 20);
            this.rdbNo.TabIndex = 7;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSi.Location = new System.Drawing.Point(4, 2);
            this.rdbSi.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(38, 20);
            this.rdbSi.TabIndex = 6;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "Si";
            this.rdbSi.UseVisualStyleBackColor = true;
            // 
            // lblOtraAutoridad
            // 
            this.lblOtraAutoridad.AutoSize = true;
            this.lblOtraAutoridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtraAutoridad.Location = new System.Drawing.Point(16, 378);
            this.lblOtraAutoridad.Name = "lblOtraAutoridad";
            this.lblOtraAutoridad.Size = new System.Drawing.Size(175, 16);
            this.lblOtraAutoridad.TabIndex = 25;
            this.lblOtraAutoridad.Text = "Otra Autoridad (especifique)";
            // 
            // txtRespuestaAutoridad
            // 
            this.txtRespuestaAutoridad.Location = new System.Drawing.Point(19, 397);
            this.txtRespuestaAutoridad.Name = "txtRespuestaAutoridad";
            this.txtRespuestaAutoridad.Size = new System.Drawing.Size(235, 20);
            this.txtRespuestaAutoridad.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoVisual.Properties.Resources._845eaab6_1665_4fcd_90c6_dd832542c439;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblFechadeHoy
            // 
            this.lblFechadeHoy.AutoSize = true;
            this.lblFechadeHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechadeHoy.Location = new System.Drawing.Point(470, 32);
            this.lblFechadeHoy.Name = "lblFechadeHoy";
            this.lblFechadeHoy.Size = new System.Drawing.Size(104, 18);
            this.lblFechadeHoy.TabIndex = 30;
            this.lblFechadeHoy.Text = "Fecha de Hoy:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(580, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(591, 387);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(89, 35);
            this.btnAtras.TabIndex = 31;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Siguientes
            // 
            this.Siguientes.Location = new System.Drawing.Point(686, 387);
            this.Siguientes.Name = "Siguientes";
            this.Siguientes.Size = new System.Drawing.Size(89, 35);
            this.Siguientes.TabIndex = 32;
            this.Siguientes.Text = "Siguiente";
            this.Siguientes.UseVisualStyleBackColor = true;
            this.Siguientes.Click += new System.EventHandler(this.Siguientes_Click);
            // 
            // FrmTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Siguientes);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblFechadeHoy);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtRespuestaAutoridad);
            this.Controls.Add(this.lblOtraAutoridad);
            this.Controls.Add(this.pnlSiNo);
            this.Controls.Add(this.lblAuxilio);
            this.Controls.Add(this.cmbEstados);
            this.Controls.Add(this.lblSeleccionaEstado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAgresoroDelincuente);
            this.Name = "FrmTres";
            this.Text = "FrmTres";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSiNo.ResumeLayout(false);
            this.pnlSiNo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgresoroDelincuente;
        private System.Windows.Forms.RadioButton rdbDesconocido;
        private System.Windows.Forms.RadioButton rdbConocido;
        private System.Windows.Forms.RadioButton rdbPariente;
        private System.Windows.Forms.RadioButton rdbAmigo;
        private System.Windows.Forms.RadioButton rdbVecino;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSeleccionaEstado;
        private System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.Label lblAuxilio;
        private System.Windows.Forms.Panel pnlSiNo;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.Label lblOtraAutoridad;
        private System.Windows.Forms.TextBox txtRespuestaAutoridad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFechadeHoy;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button Siguientes;
    }
}