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
    public partial class Triangulos : Form
    {
        public Triangulos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int l1 = Convert.ToInt16(tbLado1.Text);
            int l2 = Convert.ToInt16(tbLado2.Text);
            int l3 = Convert.ToInt16(tbLado3.Text);
            
            if (((l1==l2) && (l1 != l3)) || ((l1==l3) && (l1 != l2)) || ((l2==l3) && (l1!=l2)))
            {
                MessageBox.Show("El triangulo es Isosceles");

            }
            else {
                if((l1==l2) && (l1==l3)){
                    MessageBox.Show("El triangulo es Equilatero");
                }
                else
                {
                    MessageBox.Show("El triangulo es Escaleno ");
                }
                    }
        }
    }
}
