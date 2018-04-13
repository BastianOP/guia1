using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioSimple
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gbPromedio_Enter(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
           int notauno= Convert.ToInt16(tbNota1.Text);
           int notados =Convert.ToInt16(tbNota2.Text);
           int Promedio = (notauno + notados);
           string PromedioTxt = Convert.ToString(Promedio);




            lbNombre.Text = tbNombre.Text;
            lbPromedio.Text = PromedioTxt;
        }
    }
}
