using Cooperativa_Julian_vega_felix.modelado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cooperativa_Julian_vega_felix.capa_presentación
{
    public partial class eliminarPersonalId : Form
    {
        PruebaContext dt = new PruebaContext();
        public event EventHandler PersonalEliminado;
        public eliminarPersonalId()
        {
            InitializeComponent();
        }

        private void btnEliminarPersonal_Click(object sender, EventArgs e)
        {
            int idPersonal;

            if (!int.TryParse(txtIdPersonal.Text, out idPersonal))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Personal personal = dt.Personals.Find(idPersonal);

            if (personal == null)
            {
                MessageBox.Show("El Id Del Personal No Se Encontro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar al trabajador con ID: " + idPersonal + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Eliminar el trabajador de la base de datos
                    dt.Personals.Remove(personal);
                    dt.SaveChanges();
                    MessageBox.Show("El trabajador ha sido eliminado correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Disparar el evento TrabajadorEliminado
                    PersonalEliminado?.Invoke(this, EventArgs.Empty);

                    // Cerrar la ventana de eliminarTrabajador
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el Personal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void txtIdPersonal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                btnEliminarPersonal.Focus();
            }
            
            // Validar si el carácter ingresado es un número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es un número ni una tecla de retroceso, cancelar el evento
                e.Handled = true;
            }
        }

        private void eliminarPersonalId_Load(object sender, EventArgs e)
        {

        }
    }
}
