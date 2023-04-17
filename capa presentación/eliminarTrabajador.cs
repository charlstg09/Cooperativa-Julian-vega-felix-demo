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
    public partial class eliminarTrabajador : Form
    {
        private PruebaContext dt; // Crear una instancia de PruebaContext como campo de clase
        public event EventHandler TrabajadorEliminado;
        public eliminarTrabajador()
        {
            InitializeComponent();
            dt = new PruebaContext();
        }

        private void eliminarTrabajador_Load(object sender, EventArgs e)
        {

        }

        private void txtIdTtabajador_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar si el carácter ingresado es un número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es un número ni una tecla de retroceso, cancelar el evento
                e.Handled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void bntEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del trabajador a eliminar desde el TextBox
            int idTrabajador;
            if (!int.TryParse(txtIdTtabajador.Text, out idTrabajador))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Consultar el trabajador en la base de datos
            Trabajadore trabajador = dt.Trabajadores.Find(idTrabajador);

            if (trabajador == null)
            {
                MessageBox.Show("No se encontró ningún trabajador con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mostrar mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar al trabajador con ID: " + idTrabajador + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Eliminar el trabajador de la base de datos
                    dt.Trabajadores.Remove(trabajador);
                    dt.SaveChanges();
                    MessageBox.Show("El trabajador ha sido eliminado correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Disparar el evento TrabajadorEliminado
                    TrabajadorEliminado?.Invoke(this, EventArgs.Empty);

                    // Cerrar la ventana de eliminarTrabajador
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el trabajador: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

