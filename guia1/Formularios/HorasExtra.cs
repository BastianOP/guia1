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
    public partial class HorasExtra : Form
    {
        public HorasExtra()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int horas = Convert.ToInt16(tbHoras.Text);
            int sueldo = Convert.ToInt32(tbSueldo.Text);
            int monto = (((sueldo / 30)*28)/180);
            int totalhoras = monto * horas;

            lbMonto.Text = "El trabajador "+tbEmpleado.Text+" en el mes de "+tbMes.Text+ " ha generado \run total de "+horas+" horas extra que equivale a $"+monto+ " por hora \ry un total de $ "+totalhoras;
           



        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
