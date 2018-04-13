using guia1.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guia1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            PromedioSimple nombre = new PromedioSimple();
            nombre.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PuntajeFinal nuevo = new PuntajeFinal();
            nuevo.Show();
        }

        private void btnHoras_Click(object sender, EventArgs e)
        {
            HorasExtra nuevo = new HorasExtra();
            nuevo.Show();
        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            Respaldo nuevo = new Respaldo();
            nuevo.Show();
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            HermanoMayor nuevo = new HermanoMayor();
            nuevo.Show();
        }

        private void btnArandanos_Click(object sender, EventArgs e)
        {
            Arandanos nuevo = new Arandanos();
            nuevo.Show();
        }

        private void btnNumMayor_Click(object sender, EventArgs e)
        {
            NumeroMayor nuevo = new NumeroMayor();
            nuevo.Show();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            Triangulos nuevo = new Triangulos();
            nuevo.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas nuevo = new Ventas();
            nuevo.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Unidades nuevo = new Unidades();
            nuevo.Show();
        }

        private void btnVocal_Click(object sender, EventArgs e)
        {
            
        }
    }
}
