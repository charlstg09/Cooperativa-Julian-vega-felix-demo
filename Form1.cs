using Microsoft.VisualBasic.PowerPacks;

namespace Cooperativa_Julian_vega_felix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            capa_presentación.Principal nuevaVenana = new capa_presentación.Principal();
            nuevaVenana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            capa_presentación.Principal inicio = new capa_presentación.Principal();
            inicio.Show();
        }
    }
}