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
    public partial class Unidades : Form
    {
        public Unidades()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt16(tbEntero.Text);
            int decena = numero / 10;
            int resto = numero % 10;
            int unidad = resto;

            MessageBox.Show("El numero tiene " + decena + " decenas y " + unidad + " unidades");
        }
    }
}
