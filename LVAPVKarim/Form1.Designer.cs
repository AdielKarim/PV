namespace LVAPVKarim
{
    partial class Form1
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
            this.lblFormaUno = new System.Windows.Forms.Label();
            this.btnLlamarAformaDos = new System.Windows.Forms.Button();
            this.btnLlamarAFormaTres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFormaUno
            // 
            this.lblFormaUno.AutoSize = true;
            this.lblFormaUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaUno.ForeColor = System.Drawing.Color.Red;
            this.lblFormaUno.Location = new System.Drawing.Point(292, 175);
            this.lblFormaUno.Name = "lblFormaUno";
            this.lblFormaUno.Size = new System.Drawing.Size(179, 37);
            this.lblFormaUno.TabIndex = 0;
            this.lblFormaUno.Text = "Forma Uno";
            // 
            // btnLlamarAformaDos
            // 
            this.btnLlamarAformaDos.Location = new System.Drawing.Point(584, 369);
            this.btnLlamarAformaDos.Name = "btnLlamarAformaDos";
            this.btnLlamarAformaDos.Size = new System.Drawing.Size(163, 23);
            this.btnLlamarAformaDos.TabIndex = 1;
            this.btnLlamarAformaDos.Text = "Llamar Forma Dos";
            this.btnLlamarAformaDos.UseVisualStyleBackColor = true;
            this.btnLlamarAformaDos.Click += new System.EventHandler(this.btnLlamarAformaDos_Click);
            // 
            // btnLlamarAFormaTres
            // 
            this.btnLlamarAFormaTres.Location = new System.Drawing.Point(558, 318);
            this.btnLlamarAFormaTres.Name = "btnLlamarAFormaTres";
            this.btnLlamarAFormaTres.Size = new System.Drawing.Size(189, 30);
            this.btnLlamarAFormaTres.TabIndex = 2;
            this.btnLlamarAFormaTres.Text = "Llamar A Forma Tres";
            this.btnLlamarAFormaTres.UseVisualStyleBackColor = true;
            this.btnLlamarAFormaTres.Click += new System.EventHandler(this.btnLlamarAFormaTres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLlamarAFormaTres);
            this.Controls.Add(this.btnLlamarAformaDos);
            this.Controls.Add(this.lblFormaUno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormaUno;
        private System.Windows.Forms.Button btnLlamarAformaDos;
        private System.Windows.Forms.Button btnLlamarAFormaTres;
    }
}

