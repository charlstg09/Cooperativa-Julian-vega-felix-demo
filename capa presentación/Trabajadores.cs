using Cooperativa_Julian_vega_felix.modelado;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Cooperativa_Julian_vega_felix.capa_presentación
{
    public partial class bntpersonal : Form
    {
        private PruebaContext dt; // Crear una instancia de PruebaContext como campo de clase

        public bntpersonal()
        {
            InitializeComponent();
            dt = new PruebaContext(); // Inicializar la instancia de PruebaContext en el constructor
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtCurp.Text) || string.IsNullOrEmpty(txtRfc.Text))
            {
                MessageBox.Show("Porfavor Rellene Los Campos Faltantes", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Trabajadore trabajador = new Trabajadore();

                trabajador.NomTra = txtNombre.Text;
                trabajador.ApelTra = txtApellido.Text;
                trabajador.TelTra = txtTelefono.Text;
                trabajador.Rfc = txtRfc.Text;
                trabajador.Curp = txtCurp.Text;

                dt.Trabajadores.Add(trabajador);
                dt.SaveChanges();


                MessageBox.Show("Trabajador registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                refrescar();
            }
        }

        private void txtRfc_TextChanged(object sender, EventArgs e)
        {
            txtRfc.MaxLength = 16;
        }

        private void txtRfc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtCurp_TextChanged(object sender, EventArgs e)
        {
            txtCurp.MaxLength = 18;
        }

        private void txtCurp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            txtTelefono.MaxLength = 10;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar si el carácter ingresado es un número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es un número ni una tecla de retroceso, cancelar el evento
                e.Handled = true;
            }
        }
        private void ConfigurarDataGridView()
        {
            // Configurar el DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Ajustar automáticamente el tamaño de las columnas
            dataGridView1.ScrollBars = ScrollBars.Vertical; // Habilitar la barra de desplazamiento vertical
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bntpersonal_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        public void refrescar()
        {
            var query = dt.Trabajadores.ToList();
            dataGridView1.DataSource = query;
            ConfigurarDataGridView();
        }

        private void bntEliminar_Click(object sender, EventArgs e)
        {
            eliminarTrabajador eliminar = new eliminarTrabajador();

            eliminar.ShowDialog();

        }
    }
}
