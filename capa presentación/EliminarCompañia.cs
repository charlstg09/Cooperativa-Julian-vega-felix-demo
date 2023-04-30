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
    public partial class EliminarCompañia : Form
    {
        PruebaContext dt = new PruebaContext();
        public event EventHandler CompañiaEliminada;
        public EliminarCompañia()
        {
            InitializeComponent();
        }

        private void txtIdPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo caracteres numéricos y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Rechazar el carácter
            }

            if (e.KeyChar == 13)
            {
                e.Handled = true;
                btnEliminarPersonal.Focus();
            }
        }

        private void btnEliminarPersonal_Click(object sender, EventArgs e)
        {
            int idCompañia;


            if (!int.TryParse(txtIdCompañia.Text, out idCompañia))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Compañium compa = dt.Compañia.Find(idCompañia);

            if (compa == null)
            {
                MessageBox.Show("El Id De la Compañia No Se Encontro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar al trabajador con ID: " + idCompañia + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Eliminar el trabajador de la base de datos
                    dt.Compañia.Remove(compa);
                    dt.SaveChanges();
                    MessageBox.Show("El trabajador ha sido eliminado correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Disparar el evento TrabajadorEliminado
                    CompañiaEliminada?.Invoke(this, EventArgs.Empty);

                    // Cerrar la ventana de eliminarTrabajador
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la Compañia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
