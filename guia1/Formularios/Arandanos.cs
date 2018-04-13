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
    public partial class Arandanos : Form
    {
        public Arandanos()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int lun = Convert.ToInt16(tbLunes.Text);
            int mar = Convert.ToInt16(tbMartes.Text);
            int mier = Convert.ToInt16(tbMiercoles.Text);
            int jue = Convert.ToInt16(tbJueves.Text);
            int vie = Convert.ToInt16(tbViernes.Text);
            int sab = Convert.ToInt16(tbSabado.Text);
            int total = (lun + mar + mier + jue + vie + sab);
            int prom = (total / 6);
            string promedio = Convert.ToString(prom);
            string cosechado = Convert.ToString(total);
           

            lbPromedio.Text = promedio;
            lbTotal.Text = cosechado;
            if (prom < 500)
            {
                MessageBox.Show("El Rendimiento es muy bajo",
                    "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
         
        }
    }
}
