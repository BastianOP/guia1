namespace guia1.Formularios
{
    partial class PuntajeFinal
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCorrectas = new System.Windows.Forms.TextBox();
            this.tbIncorrectas = new System.Windows.Forms.TextBox();
            this.tbBlanco = new System.Windows.Forms.TextBox();
            this.gbPuntaje = new System.Windows.Forms.GroupBox();
            this.lbPuntaje = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbPuntaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correctas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Incorrectas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "En blanco";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(15, 73);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(266, 20);
            this.tbNombre.TabIndex = 4;
            // 
            // tbCorrectas
            // 
            this.tbCorrectas.Location = new System.Drawing.Point(15, 181);
            this.tbCorrectas.Name = "tbCorrectas";
            this.tbCorrectas.Size = new System.Drawing.Size(49, 20);
            this.tbCorrectas.TabIndex = 5;
            // 
            // tbIncorrectas
            // 
            this.tbIncorrectas.Location = new System.Drawing.Point(118, 181);
            this.tbIncorrectas.Name = "tbIncorrectas";
            this.tbIncorrectas.Size = new System.Drawing.Size(57, 20);
            this.tbIncorrectas.TabIndex = 6;
            // 
            // tbBlanco
            // 
            this.tbBlanco.Location = new System.Drawing.Point(229, 181);
            this.tbBlanco.Name = "tbBlanco";
            this.tbBlanco.Size = new System.Drawing.Size(52, 20);
            this.tbBlanco.TabIndex = 7;
            // 
            // gbPuntaje
            // 
            this.gbPuntaje.Controls.Add(this.lbPuntaje);
            this.gbPuntaje.Controls.Add(this.lbNombre);
            this.gbPuntaje.Controls.Add(this.label6);
            this.gbPuntaje.Location = new System.Drawing.Point(384, 26);
            this.gbPuntaje.Name = "gbPuntaje";
            this.gbPuntaje.Size = new System.Drawing.Size(350, 242);
            this.gbPuntaje.TabIndex = 25;
            this.gbPuntaje.TabStop = false;
            this.gbPuntaje.Text = "Puntaje Final";
            // 
            // lbPuntaje
            // 
            this.lbPuntaje.AutoSize = true;
            this.lbPuntaje.Location = new System.Drawing.Point(140, 41);
            this.lbPuntaje.Name = "lbPuntaje";
            this.lbPuntaje.Size = new System.Drawing.Size(0, 13);
            this.lbPuntaje.TabIndex = 2;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(20, 41);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(0, 13);
            this.lbNombre.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(13, 244);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 26;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(132, 244);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // PuntajeFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbPuntaje);
            this.Controls.Add(this.tbBlanco);
            this.Controls.Add(this.tbIncorrectas);
            this.Controls.Add(this.tbCorrectas);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PuntajeFinal";
            this.Text = "PuntajeFinal";
            this.gbPuntaje.ResumeLayout(false);
            this.gbPuntaje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCorrectas;
        private System.Windows.Forms.TextBox tbIncorrectas;
        private System.Windows.Forms.TextBox tbBlanco;
        private System.Windows.Forms.GroupBox gbPuntaje;
        private System.Windows.Forms.Label lbPuntaje;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
    }
}