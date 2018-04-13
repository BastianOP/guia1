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
    public partial class Respaldo : Form
    {
        public Respaldo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int gigas = Convert.ToInt32(tbGigas.Text);
            double cantidad = gigas/4.7;

            MessageBox.Show("Necesita " + cantidad + " DVD Para respaldar " + gigas + " Gigabytes");
        }
    }
}
