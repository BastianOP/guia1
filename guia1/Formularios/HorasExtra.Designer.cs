namespace guia1.Formularios
{
    partial class HorasExtra
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
            this.tbMes = new System.Windows.Forms.TextBox();
            this.tbHoras = new System.Windows.Forms.TextBox();
            this.tbSueldo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gbMonto = new System.Windows.Forms.GroupBox();
            this.lbMonto = new System.Windows.Forms.Label();
            this.tbEmpleado = new System.Windows.Forms.TextBox();
            this.gbMonto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mes de proceso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de horas extra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sueldo Base";
            // 
            // tbMes
            // 
            this.tbMes.Location = new System.Drawing.Point(16, 100);
            this.tbMes.Name = "tbMes";
            this.tbMes.Size = new System.Drawing.Size(259, 20);
            this.tbMes.TabIndex = 5;
            // 
            // tbHoras
            // 
            this.tbHoras.Location = new System.Drawing.Point(16, 148);
            this.tbHoras.Name = "tbHoras";
            this.tbHoras.Size = new System.Drawing.Size(259, 20);
            this.tbHoras.TabIndex = 6;
            // 
            // tbSueldo
            // 
            this.tbSueldo.Location = new System.Drawing.Point(16, 197);
            this.tbSueldo.Name = "tbSueldo";
            this.tbSueldo.Size = new System.Drawing.Size(259, 20);
            this.tbSueldo.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(21, 262);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gbMonto
            // 
            this.gbMonto.Controls.Add(this.lbMonto);
            this.gbMonto.Location = new System.Drawing.Point(472, 28);
            this.gbMonto.Name = "gbMonto";
            this.gbMonto.Size = new System.Drawing.Size(299, 238);
            this.gbMonto.TabIndex = 10;
            this.gbMonto.TabStop = false;
            this.gbMonto.Text = "Monto de horas";
            // 
            // lbMonto
            // 
            this.lbMonto.AutoSize = true;
            this.lbMonto.Location = new System.Drawing.Point(7, 37);
            this.lbMonto.Name = "lbMonto";
            this.lbMonto.Size = new System.Drawing.Size(0, 13);
            this.lbMonto.TabIndex = 0;
            // 
            // tbEmpleado
            // 
            this.tbEmpleado.Location = new System.Drawing.Point(13, 45);
            this.tbEmpleado.Name = "tbEmpleado";
            this.tbEmpleado.Size = new System.Drawing.Size(262, 20);
            this.tbEmpleado.TabIndex = 11;
            // 
            // HorasExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbEmpleado);
            this.Controls.Add(this.gbMonto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbSueldo);
            this.Controls.Add(this.tbHoras);
            this.Controls.Add(this.tbMes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HorasExtra";
            this.Text = "Horas Extra";
            this.gbMonto.ResumeLayout(false);
            this.gbMonto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMes;
        private System.Windows.Forms.TextBox tbHoras;
        private System.Windows.Forms.TextBox tbSueldo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gbMonto;
        private System.Windows.Forms.Label lbMonto;
        private System.Windows.Forms.TextBox tbEmpleado;
    }
}