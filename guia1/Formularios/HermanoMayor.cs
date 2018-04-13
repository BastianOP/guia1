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
    public partial class HermanoMayor : Form
    {
        public HermanoMayor()
        {
            InitializeComponent();
        }

        private void btnAveriguar_Click(object sender, EventArgs e)
        {
            int edad1 = Convert.ToInt16(tbEdad1.Text);
            int edad2 = Convert.ToInt16(tbEdad2.Text);

            if (edad1 > edad2){
                int diferencia = (edad1 - edad2);
                MessageBox.Show(tbHermano1.Text +" Es mayor "+diferencia+" años que " +tbHermano2.Text);
            }
            else
            {
                int diferencia = (edad2 - edad1);
                MessageBox.Show(tbHermano2.Text + " Es mayor " + diferencia + " años que " + tbHermano1.Text);
            }
        }
    }
}
