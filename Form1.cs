using Cooperativa_Julian_vega_felix.capa_presentación;
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

            // validar información 




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtcontaseña.UseSystemPasswordChar = true;
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string contraseña = txtcontaseña.Text;

            // Realizar consulta a la base de datos
            var admin = dt.Admins.FirstOrDefault(a => a.Usuario == usuario && a.Contraseña == contraseña);

            // Verificar si se encontró un registro con el usuario y contraseña ingresados
            if (admin != null)
            {
                // Abrir la pantalla o realizar la acción deseada
                MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aquí puedes abrir la pantalla o realizar la acción deseada para el login exitoso
                Principal principal = new Principal();

                principal.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

            
        }

        
    }
}