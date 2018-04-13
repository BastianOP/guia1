using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guia1.Formularios
{
    public partial class NumeroMayor : Form
    {
        public NumeroMayor()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(tbNumero1.Text);
            int n2 = Convert.ToInt16(tbNumero2.Text);
            int n3 = Convert.ToInt16(tbNumero3.Text);

            if(n1>n2 && n1 > n3)
            {
                MessageBox.Show("El numero " + n1 + " Es el mayor");
            }
            else
            {
                if(n2>n1 && n2 > n3)
                {
                    MessageBox.Show("El numero " + n2 + " Es el mayor");
                }
                else { MessageBox.Show("El numero " + n3 + " Es el mayor"); }
            }
        }
    }
}
