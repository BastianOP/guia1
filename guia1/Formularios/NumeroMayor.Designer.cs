namespace guia1.Formularios
{
    partial class NumeroMayor
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumero1 = new System.Windows.Forms.TextBox();
            this.tbNumero2 = new System.Windows.Forms.TextBox();
            this.tbNumero3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese 3 numeros";
            // 
            // tbNumero1
            // 
            this.tbNumero1.Location = new System.Drawing.Point(16, 92);
            this.tbNumero1.Name = "tbNumero1";
            this.tbNumero1.Size = new System.Drawing.Size(71, 20);
            this.tbNumero1.TabIndex = 1;
            // 
            // tbNumero2
            // 
            this.tbNumero2.Location = new System.Drawing.Point(16, 140);
            this.tbNumero2.Name = "tbNumero2";
            this.tbNumero2.Size = new System.Drawing.Size(71, 20);
            this.tbNumero2.TabIndex = 2;
            // 
            // tbNumero3
            // 
            this.tbNumero3.Location = new System.Drawing.Point(16, 196);
            this.tbNumero3.Name = "tbNumero3";
            this.tbNumero3.Size = new System.Drawing.Size(71, 20);
            this.tbNumero3.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(239, 137);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // NumeroMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbNumero3);
            this.Controls.Add(this.tbNumero2);
            this.Controls.Add(this.tbNumero1);
            this.Controls.Add(this.label1);
            this.Name = "NumeroMayor";
            this.Text = "NumeroMayor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumero1;
        private System.Windows.Forms.TextBox tbNumero2;
        private System.Windows.Forms.TextBox tbNumero3;
        private System.Windows.Forms.Button btnCalcular;
    }
}