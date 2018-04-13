namespace guia1.Formularios
{
    partial class Triangulos
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
            this.tbLado1 = new System.Windows.Forms.TextBox();
            this.tbLado2 = new System.Windows.Forms.TextBox();
            this.tbLado3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese medida de lados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbLado1
            // 
            this.tbLado1.Location = new System.Drawing.Point(12, 69);
            this.tbLado1.Name = "tbLado1";
            this.tbLado1.Size = new System.Drawing.Size(100, 20);
            this.tbLado1.TabIndex = 1;
            // 
            // tbLado2
            // 
            this.tbLado2.Location = new System.Drawing.Point(12, 126);
            this.tbLado2.Name = "tbLado2";
            this.tbLado2.Size = new System.Drawing.Size(100, 20);
            this.tbLado2.TabIndex = 2;
            // 
            // tbLado3
            // 
            this.tbLado3.Location = new System.Drawing.Point(12, 176);
            this.tbLado3.Name = "tbLado3";
            this.tbLado3.Size = new System.Drawing.Size(100, 20);
            this.tbLado3.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(260, 111);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Triangulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbLado3);
            this.Controls.Add(this.tbLado2);
            this.Controls.Add(this.tbLado1);
            this.Controls.Add(this.label1);
            this.Name = "Triangulos";
            this.Text = "Triangulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLado1;
        private System.Windows.Forms.TextBox tbLado2;
        private System.Windows.Forms.TextBox tbLado3;
        private System.Windows.Forms.Button btnCalcular;
    }
}