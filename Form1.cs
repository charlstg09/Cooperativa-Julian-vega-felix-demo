using Cooperativa_Julian_vega_felix.capa_presentaci�n;
using Cooperativa_Julian_vega_felix.modelado;
using Microsoft.VisualBasic.PowerPacks;
using System.Data.SqlClient;

namespace Cooperativa_Julian_vega_felix
{
    public partial class Form1 : Form
    {
        PruebaContext dt;
        public Form1()
        {
            InitializeComponent();



           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt = new PruebaContext();

            // validar informaci�n 




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtcontase�a.UseSystemPasswordChar = true;
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string contrase�a = txtcontase�a.Text;

            // Realizar consulta a la base de datos
            var admin = dt.Admins.FirstOrDefault(a => a.Usuario == usuario && a.Contrase�a == contrase�a);

            // Verificar si se encontr� un registro con el usuario y contrase�a ingresados
            if (admin != null)
            {
                // Abrir la pantalla o realizar la acci�n deseada
                MessageBox.Show("Inicio de sesi�n exitoso.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aqu� puedes abrir la pantalla o realizar la acci�n deseada para el login exitoso
                Principal principal = new Principal();

                principal.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contrase�a incorrectos.", "Error de inicio de sesi�n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

            
        }

        
    }
}