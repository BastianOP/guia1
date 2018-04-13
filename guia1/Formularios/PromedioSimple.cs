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
    public partial class PromedioSimple : Form
    {
        public PromedioSimple()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int notauno = Convert.ToInt16(tbNota1.Text);
            int notados = Convert.ToInt16(tbNota2.Text);
            int notatres = Convert.ToInt16(tbNota3.Text);
            int notacuatro = Convert.ToInt16(tbNota4.Text);
            int Promedio = (notauno + notados+notatres+notacuatro)/4;
            string PromedioTxt = Convert.ToString(Promedio);


            lbNombre.Text = tbNombre.Text;
            lbPromedio.Text = "Su promedio es "+PromedioTxt;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbNombre.Text = "";
            lbPromedio.Text = "";
            tbNombre.Text = "";
            tbNota1.Text = "";
            tbNota2.Text = "";
            tbNota3.Text = "";
            tbNota4.Text = "";
        }

        private void PromedioSimple_Load(object sender, EventArgs e)
        {

        }
    }
}
