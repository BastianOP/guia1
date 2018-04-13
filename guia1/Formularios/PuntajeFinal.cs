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
    public partial class PuntajeFinal : Form
    {
        public PuntajeFinal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gbPromedio_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int correctas = Convert.ToInt16(tbCorrectas.Text);
            int incorrectas = Convert.ToInt16(tbIncorrectas.Text);
            int blanco = Convert.ToInt16(tbIncorrectas.Text);
            int Puntaje = ((correctas * 10) + (incorrectas * -5) + (blanco * 0));


       
            lbNombre.Text = tbNombre.Text;
            lbPuntaje.Text = "Su puntaje final es " + Puntaje;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbNombre.Text = "";
            lbPuntaje.Text = "";
            tbNombre.Text = "";
            tbCorrectas.Text = "";
            tbIncorrectas.Text = "";
            tbBlanco.Text = "";
        }
    }
}
