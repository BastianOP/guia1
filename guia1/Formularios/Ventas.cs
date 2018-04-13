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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(tbVentas.Text);

           if(total>0 && total <= 500000)
            {
                MessageBox.Show("Tiene 0% de bonificacion");
            }
            else {
                if
                    (total>=501000 && total <= 1500000){
                        MessageBox.Show("Tiene 3% de bonificacion");
                }
                else { if(total>=1500001 && total <= 2500000)
                    {
                        MessageBox.Show("Tiene 8% de bonificacion");
                    }
                    else { if (total >= 2500001)
                        {
                            MessageBox.Show("Tiene 12% de bonificacion");
                        } } }
                } }
        }
    }

