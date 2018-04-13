namespace guia1.Formularios
{
    partial class HermanoMayor
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHermano1 = new System.Windows.Forms.TextBox();
            this.tbEdad1 = new System.Windows.Forms.TextBox();
            this.tbHermano2 = new System.Windows.Forms.TextBox();
            this.tbEdad2 = new System.Windows.Forms.TextBox();
            this.btnAveriguar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre hermano 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre hermano 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad hermano 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad hermano 2";
            // 
            // tbHermano1
            // 
            this.tbHermano1.Location = new System.Drawing.Point(12, 41);
            this.tbHermano1.Name = "tbHermano1";
            this.tbHermano1.Size = new System.Drawing.Size(100, 20);
            this.tbHermano1.TabIndex = 4;
            // 
            // tbEdad1
            // 
            this.tbEdad1.Location = new System.Drawing.Point(12, 90);
            this.tbEdad1.Name = "tbEdad1";
            this.tbEdad1.Size = new System.Drawing.Size(100, 20);
            this.tbEdad1.TabIndex = 5;
            // 
            // tbHermano2
            // 
            this.tbHermano2.Location = new System.Drawing.Point(12, 142);
            this.tbHermano2.Name = "tbHermano2";
            this.tbHermano2.Size = new System.Drawing.Size(100, 20);
            this.tbHermano2.TabIndex = 6;
            // 
            // tbEdad2
            // 
            this.tbEdad2.Location = new System.Drawing.Point(9, 198);
            this.tbEdad2.Name = "tbEdad2";
            this.tbEdad2.Size = new System.Drawing.Size(100, 20);
            this.tbEdad2.TabIndex = 7;
            // 
            // btnAveriguar
            // 
            this.btnAveriguar.Location = new System.Drawing.Point(16, 245);
            this.btnAveriguar.Name = "btnAveriguar";
            this.btnAveriguar.Size = new System.Drawing.Size(75, 23);
            this.btnAveriguar.TabIndex = 8;
            this.btnAveriguar.Text = "Averiguar";
            this.btnAveriguar.UseVisualStyleBackColor = true;
            this.btnAveriguar.Click += new System.EventHandler(this.btnAveriguar_Click);
            // 
            // HermanoMayor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAveriguar);
            this.Controls.Add(this.tbEdad2);
            this.Controls.Add(this.tbHermano2);
            this.Controls.Add(this.tbEdad1);
            this.Controls.Add(this.tbHermano1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HermanoMayor";
            this.Text = "HermanoMayor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHermano1;
        private System.Windows.Forms.TextBox tbEdad1;
        private System.Windows.Forms.TextBox tbHermano2;
        private System.Windows.Forms.TextBox tbEdad2;
        private System.Windows.Forms.Button btnAveriguar;
    }
}