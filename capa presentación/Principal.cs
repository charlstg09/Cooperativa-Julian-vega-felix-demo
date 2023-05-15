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
using Cooperativa_Julian_vega_felix.modelado;

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
        private Form formularioActivo = null;
        private void OpenForm(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelPrincipal.AutoScroll = true;
            panelPrincipal.Controls.Add(formularioHijo);
            panelPrincipal.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnpersonal_Click(object sender, EventArgs e)
        {
            OpenForm(new bntpersonal());
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            OpenForm(new Compañias());
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            OpenForm(new entrega());
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            OpenForm(new historial());
        }

        private void btnMarisco_Click(object sender, EventArgs e)
        {

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
