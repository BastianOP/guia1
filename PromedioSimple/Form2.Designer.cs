namespace PromedioSimple
{
    partial class Form2
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNota1 = new System.Windows.Forms.TextBox();
            this.tbNota2 = new System.Windows.Forms.TextBox();
            this.tbNota3 = new System.Windows.Forms.TextBox();
            this.tbNota4 = new System.Windows.Forms.TextBox();
            this.gbPromedio = new System.Windows.Forms.GroupBox();
            this.lbPromedio = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbPromedio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(12, 45);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(172, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Alumno";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota 1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nota 4";
            // 
            // tbNota1
            // 
            this.tbNota1.Location = new System.Drawing.Point(16, 140);
            this.tbNota1.Name = "tbNota1";
            this.tbNota1.Size = new System.Drawing.Size(36, 20);
            this.tbNota1.TabIndex = 6;
            // 
            // tbNota2
            // 
            this.tbNota2.Location = new System.Drawing.Point(95, 140);
            this.tbNota2.Name = "tbNota2";
            this.tbNota2.Size = new System.Drawing.Size(36, 20);
            this.tbNota2.TabIndex = 7;
            // 
            // tbNota3
            // 
            this.tbNota3.Location = new System.Drawing.Point(170, 140);
            this.tbNota3.Name = "tbNota3";
            this.tbNota3.Size = new System.Drawing.Size(36, 20);
            this.tbNota3.TabIndex = 8;
            // 
            // tbNota4
            // 
            this.tbNota4.Location = new System.Drawing.Point(250, 140);
            this.tbNota4.Name = "tbNota4";
            this.tbNota4.Size = new System.Drawing.Size(36, 20);
            this.tbNota4.TabIndex = 9;
            // 
            // gbPromedio
            // 
            this.gbPromedio.Controls.Add(this.lbPromedio);
            this.gbPromedio.Controls.Add(this.lbNombre);
            this.gbPromedio.Controls.Add(this.label6);
            this.gbPromedio.Location = new System.Drawing.Point(400, 26);
            this.gbPromedio.Name = "gbPromedio";
            this.gbPromedio.Size = new System.Drawing.Size(350, 242);
            this.gbPromedio.TabIndex = 10;
            this.gbPromedio.TabStop = false;
            this.gbPromedio.Text = "Promedio";
            this.gbPromedio.Enter += new System.EventHandler(this.gbPromedio_Enter);
            // 
            // lbPromedio
            // 
            this.lbPromedio.AutoSize = true;
            this.lbPromedio.Location = new System.Drawing.Point(140, 41);
            this.lbPromedio.Name = "lbPromedio";
            this.lbPromedio.Size = new System.Drawing.Size(35, 13);
            this.lbPromedio.TabIndex = 2;
            this.lbPromedio.Text = "label7";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(20, 41);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(35, 13);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(16, 245);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 12;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(122, 245);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // PromedioSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.gbPromedio);
            this.Controls.Add(this.tbNota4);
            this.Controls.Add(this.tbNota3);
            this.Controls.Add(this.tbNota2);
            this.Controls.Add(this.tbNota1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombre);
            this.Name = "PromedioSimple";
            this.Text = "Promedio Simple";
            this.gbPromedio.ResumeLayout(false);
            this.gbPromedio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNota1;
        private System.Windows.Forms.TextBox tbNota2;
        private System.Windows.Forms.TextBox tbNota3;
        private System.Windows.Forms.TextBox tbNota4;
        private System.Windows.Forms.GroupBox gbPromedio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPromedio;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

