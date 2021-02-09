namespace LVAPVKarim
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
            this.lblFormaTres = new System.Windows.Forms.Label();
            this.btnLlamarAFormaDos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFormaTres
            // 
            this.lblFormaTres.AutoSize = true;
            this.lblFormaTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaTres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFormaTres.Location = new System.Drawing.Point(322, 76);
            this.lblFormaTres.Name = "lblFormaTres";
            this.lblFormaTres.Size = new System.Drawing.Size(272, 55);
            this.lblFormaTres.TabIndex = 0;
            this.lblFormaTres.Text = "Forma Tres";
            // 
            // btnLlamarAFormaDos
            // 
            this.btnLlamarAFormaDos.Location = new System.Drawing.Point(552, 230);
            this.btnLlamarAFormaDos.Name = "btnLlamarAFormaDos";
            this.btnLlamarAFormaDos.Size = new System.Drawing.Size(133, 39);
            this.btnLlamarAFormaDos.TabIndex = 1;
            this.btnLlamarAFormaDos.Text = "Llamar a Forma Dos";
            this.btnLlamarAFormaDos.UseVisualStyleBackColor = true;
            this.btnLlamarAFormaDos.Click += new System.EventHandler(this.btnLlamarAFormaDos_Click);
            // 
            // FrmTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLlamarAFormaDos);
            this.Controls.Add(this.lblFormaTres);
            this.Name = "FrmTres";
            this.Text = "FrmTres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormaTres;
        private System.Windows.Forms.Button btnLlamarAFormaDos;
    }
}