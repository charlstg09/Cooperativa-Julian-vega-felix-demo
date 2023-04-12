using Cooperativa_Julian_vega_felix.capa_presentación;
using Microsoft.VisualBasic.PowerPacks;
using System.Data.SqlClient;

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
            txtcontaseña.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();

            principal.Show();

            this.Hide();

            
        }
    }
}