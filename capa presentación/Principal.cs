using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cooperativa_Julian_vega_felix.capa_presentación;
using System.Windows.Forms;

namespace Cooperativa_Julian_vega_felix.capa_presentación
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

        

           
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            historial historial = new historial();

            historial.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            entrega entrega = new entrega();

            entrega.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bntpersonal personal = new bntpersonal();

            personal.Show();

            this.Hide();
        }
    }
}
