namespace ProyectoVisual
{
    partial class frmVentanaUno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentanaUno));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFechaDeNacimiento = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechadeHoy = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.grpEstadoCivil = new System.Windows.Forms.GroupBox();
            this.chcViudo = new System.Windows.Forms.CheckBox();
            this.chcDivorciada = new System.Windows.Forms.CheckBox();
            this.chcSoltero = new System.Windows.Forms.CheckBox();
            this.chcCasado = new System.Windows.Forms.CheckBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lstGenero = new System.Windows.Forms.ListBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblUstedViveEn = new System.Windows.Forms.Label();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.lblVictima = new System.Windows.Forms.Label();
            this.pnlSiNo = new System.Windows.Forms.Panel();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.prbAumento = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpEstadoCivil.SuspendLayout();
            this.grpDatosPersonales.SuspendLayout();
            this.pnlSiNo.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(160, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(84, 18);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre(s):";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(160, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 24);
            this.textBox2.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(6, 80);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(71, 18);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellidos:";
            // 
            // lblFechaDeNacimiento
            // 
            this.lblFechaDeNacimiento.AutoSize = true;
            this.lblFechaDeNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeNacimiento.Location = new System.Drawing.Point(6, 117);
            this.lblFechaDeNacimiento.Name = "lblFechaDeNacimiento";
            this.lblFechaDeNacimiento.Size = new System.Drawing.Size(152, 18);
            this.lblFechaDeNacimiento.TabIndex = 4;
            this.lblFechaDeNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(160, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 24);
            this.textBox3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoVisual.Properties.Resources._845eaab6_1665_4fcd_90c6_dd832542c439;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(580, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // lblFechadeHoy
            // 
            this.lblFechadeHoy.AutoSize = true;
            this.lblFechadeHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechadeHoy.Location = new System.Drawing.Point(470, 36);
            this.lblFechadeHoy.Name = "lblFechadeHoy";
            this.lblFechadeHoy.Size = new System.Drawing.Size(104, 18);
            this.lblFechadeHoy.TabIndex = 10;
            this.lblFechadeHoy.Text = "Fecha de Hoy:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(6, 149);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(46, 18);
            this.lblEdad.TabIndex = 11;
            this.lblEdad.Text = "Edad:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(160, 147);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(222, 24);
            this.textBox4.TabIndex = 12;
            // 
            // grpEstadoCivil
            // 
            this.grpEstadoCivil.BackColor = System.Drawing.Color.White;
            this.grpEstadoCivil.Controls.Add(this.chcViudo);
            this.grpEstadoCivil.Controls.Add(this.chcDivorciada);
            this.grpEstadoCivil.Controls.Add(this.chcSoltero);
            this.grpEstadoCivil.Controls.Add(this.chcCasado);
            this.grpEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEstadoCivil.Location = new System.Drawing.Point(625, 18);
            this.grpEstadoCivil.Name = "grpEstadoCivil";
            this.grpEstadoCivil.Size = new System.Drawing.Size(119, 117);
            this.grpEstadoCivil.TabIndex = 13;
            this.grpEstadoCivil.TabStop = false;
            this.grpEstadoCivil.Text = "Estado Civil";
            // 
            // chcViudo
            // 
            this.chcViudo.AutoSize = true;
            this.chcViudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcViudo.Location = new System.Drawing.Point(6, 89);
            this.chcViudo.Name = "chcViudo";
            this.chcViudo.Size = new System.Drawing.Size(82, 22);
            this.chcViudo.TabIndex = 14;
            this.chcViudo.Text = "Viudo(a)";
            this.chcViudo.UseVisualStyleBackColor = true;
            // 
            // chcDivorciada
            // 
            this.chcDivorciada.AutoSize = true;
            this.chcDivorciada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcDivorciada.Location = new System.Drawing.Point(6, 68);
            this.chcDivorciada.Name = "chcDivorciada";
            this.chcDivorciada.Size = new System.Drawing.Size(116, 22);
            this.chcDivorciada.TabIndex = 8;
            this.chcDivorciada.Text = "Divorciado(a)";
            this.chcDivorciada.UseVisualStyleBackColor = true;
            // 
            // chcSoltero
            // 
            this.chcSoltero.AutoSize = true;
            this.chcSoltero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcSoltero.Location = new System.Drawing.Point(6, 48);
            this.chcSoltero.Name = "chcSoltero";
            this.chcSoltero.Size = new System.Drawing.Size(93, 22);
            this.chcSoltero.TabIndex = 8;
            this.chcSoltero.Text = "Soltero(a)";
            this.chcSoltero.UseVisualStyleBackColor = true;
            this.chcSoltero.CheckedChanged += new System.EventHandler(this.chcSoltero_CheckedChanged);
            // 
            // chcCasado
            // 
            this.chcCasado.AutoSize = true;
            this.chcCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcCasado.Location = new System.Drawing.Point(6, 25);
            this.chcCasado.Name = "chcCasado";
            this.chcCasado.Size = new System.Drawing.Size(97, 22);
            this.chcCasado.TabIndex = 6;
            this.chcCasado.Text = "Casado(a)";
            this.chcCasado.UseVisualStyleBackColor = true;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(6, 180);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(136, 18);
            this.lblNumero.TabIndex = 14;
            this.lblNumero.Text = "Numero de Celular:";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoElectronico.Location = new System.Drawing.Point(6, 215);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(138, 18);
            this.lblCorreoElectronico.TabIndex = 15;
            this.lblCorreoElectronico.Text = "Correo Electronico:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(160, 180);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(222, 24);
            this.textBox5.TabIndex = 16;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(160, 215);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(222, 24);
            this.textBox6.TabIndex = 17;
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.lblGenero);
            this.grpDatosPersonales.Controls.Add(this.textBox7);
            this.grpDatosPersonales.Controls.Add(this.lstGenero);
            this.grpDatosPersonales.Controls.Add(this.lblNombre);
            this.grpDatosPersonales.Controls.Add(this.grpEstadoCivil);
            this.grpDatosPersonales.Controls.Add(this.textBox6);
            this.grpDatosPersonales.Controls.Add(this.lblApellido);
            this.grpDatosPersonales.Controls.Add(this.textBox5);
            this.grpDatosPersonales.Controls.Add(this.lblFechaDeNacimiento);
            this.grpDatosPersonales.Controls.Add(this.lblCorreoElectronico);
            this.grpDatosPersonales.Controls.Add(this.textBox4);
            this.grpDatosPersonales.Controls.Add(this.lblEdad);
            this.grpDatosPersonales.Controls.Add(this.lblNumero);
            this.grpDatosPersonales.Controls.Add(this.textBox1);
            this.grpDatosPersonales.Controls.Add(this.textBox2);
            this.grpDatosPersonales.Controls.Add(this.textBox3);
            this.grpDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatosPersonales.Location = new System.Drawing.Point(12, 88);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(776, 251);
            this.grpDatosPersonales.TabIndex = 18;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "1. Datos Personales";
            this.grpDatosPersonales.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.White;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(437, 18);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(58, 18);
            this.lblGenero.TabIndex = 20;
            this.lblGenero.Text = "Genero";
            this.lblGenero.Click += new System.EventHandler(this.lblGenero_Click);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(436, 107);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(165, 24);
            this.textBox7.TabIndex = 19;
            this.textBox7.Text = "Escribe Aqui";
            // 
            // lstGenero
            // 
            this.lstGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGenero.FormattingEnabled = true;
            this.lstGenero.ItemHeight = 18;
            this.lstGenero.Items.AddRange(new object[] {
            "Masculino ",
            "Femenino",
            "Prefiero no decirlo"});
            this.lstGenero.Location = new System.Drawing.Point(436, 43);
            this.lstGenero.Name = "lstGenero";
            this.lstGenero.Size = new System.Drawing.Size(165, 58);
            this.lstGenero.TabIndex = 18;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(699, 403);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(89, 35);
            this.btnSiguiente.TabIndex = 18;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblUstedViveEn
            // 
            this.lblUstedViveEn.AutoSize = true;
            this.lblUstedViveEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUstedViveEn.Location = new System.Drawing.Point(18, 342);
            this.lblUstedViveEn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUstedViveEn.Name = "lblUstedViveEn";
            this.lblUstedViveEn.Size = new System.Drawing.Size(120, 18);
            this.lblUstedViveEn.TabIndex = 19;
            this.lblUstedViveEn.Text = "2. Usted Vive En:";
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
            this.cmbEstados.Location = new System.Drawing.Point(142, 341);
            this.cmbEstados.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(118, 24);
            this.cmbEstados.TabIndex = 20;
            this.cmbEstados.Text = "Aguascalientes";
            // 
            // lblVictima
            // 
            this.lblVictima.AutoSize = true;
            this.lblVictima.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVictima.Location = new System.Drawing.Point(18, 374);
            this.lblVictima.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVictima.Name = "lblVictima";
            this.lblVictima.Size = new System.Drawing.Size(577, 18);
            this.lblVictima.TabIndex = 21;
            this.lblVictima.Text = "3. Este año ¿Usted o algun familiar o conocido ha sido victima de un delito en Mé" +
    "xico?";
            // 
            // pnlSiNo
            // 
            this.pnlSiNo.BackColor = System.Drawing.Color.White;
            this.pnlSiNo.Controls.Add(this.rdbNo);
            this.pnlSiNo.Controls.Add(this.rdbSi);
            this.pnlSiNo.Location = new System.Drawing.Point(21, 396);
            this.pnlSiNo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSiNo.Name = "pnlSiNo";
            this.pnlSiNo.Size = new System.Drawing.Size(110, 50);
            this.pnlSiNo.TabIndex = 23;
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
            // prbAumento
            // 
            this.prbAumento.BackColor = System.Drawing.Color.White;
            this.prbAumento.Location = new System.Drawing.Point(506, 7);
            this.prbAumento.Name = "prbAumento";
            this.prbAumento.Size = new System.Drawing.Size(282, 23);
            this.prbAumento.TabIndex = 24;
            this.prbAumento.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // frmVentanaUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prbAumento);
            this.Controls.Add(this.pnlSiNo);
            this.Controls.Add(this.lblVictima);
            this.Controls.Add(this.cmbEstados);
            this.Controls.Add(this.lblUstedViveEn);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.grpDatosPersonales);
            this.Controls.Add(this.lblFechadeHoy);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentanaUno";
            this.Text = "Formulario de Inseguridad";
            this.Load += new System.EventHandler(this.frmVentanaUno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpEstadoCivil.ResumeLayout(false);
            this.grpEstadoCivil.PerformLayout();
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.pnlSiNo.ResumeLayout(false);
            this.pnlSiNo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFechaDeNacimiento;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFechadeHoy;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox grpEstadoCivil;
        private System.Windows.Forms.CheckBox chcViudo;
        private System.Windows.Forms.CheckBox chcDivorciada;
        private System.Windows.Forms.CheckBox chcSoltero;
        private System.Windows.Forms.CheckBox chcCasado;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblUstedViveEn;
        private System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.Label lblVictima;
        private System.Windows.Forms.Panel pnlSiNo;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.ProgressBar prbAumento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ListBox lstGenero;
    }
}

