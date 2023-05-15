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
    public partial class Compañias : Form
    {
        PruebaContext dt = new PruebaContext();
        public Compañias()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Compañias_Load(object sender, EventArgs e)
        {



            refrescar();



        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true; // Indica que se ha manejado el evento y que no debe propagarse más
            }

            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtEncargado.Focus();
            }

        }

        private void txtEncargado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true; // Indica que se ha manejado el evento y que no debe propagarse más
            }

            if (e.KeyChar == 13)
            {
                e.Handled = true;
               txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtEmail.Focus();
            }
            // Permitir solo caracteres numéricos y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Rechazar el carácter
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                btnAgregar.Focus();
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            txtTelefono.MaxLength = 10;
        }
        public void configurar()
        {
            dataGridView1.Columns[0].HeaderText = "ID Compañia";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Encargado";
            dataGridView1.Columns[3].HeaderText = "Telefono";
            dataGridView1.Columns[4].HeaderText = "Email";
        }
        public void refrescar()
        {
            var compa = dt.Compañia.ToList();
            dataGridView1.DataSource = compa;
            configurar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtNombre.Focus();
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEncargado.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Porfavor Rellene Los Campos Faltantes", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (var dt = new PruebaContext())
                {
                    if (dt.Compañia.Any(x => x.NumComp == txtTelefono.Text))
                    {
                        MessageBox.Show("El numero registrado ya existe porfavor ingrese otro", "Datos Repetidos",MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (dt.Compañia.Any(x => x.EmaComp == txtEmail.Text))
                    {
                        MessageBox.Show("El email ingresado ya existe porfvafor ingrese otro", "Datos repetidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (dt.Compañia.Any(x => x.NomCom == txtNombre.Text))
                    {
                        MessageBox.Show("El nombre ingresado ya existe porfvafor ingrese otro", "Datos repetidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }
                    else
                    {
                        Compañium compa = new Compañium();

                        compa.NomCom = txtNombre.Text;
                        compa.EncComp = txtEncargado.Text;
                        compa.NumComp = txtTelefono.Text;
                        compa.EmaComp = txtEmail.Text;

                        dt.Compañia.Add(compa);
                        dt.SaveChanges();


                        MessageBox.Show("Trabajador registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        refrescar();
                        txtNombre.Text = "";
                        txtEncargado.Text = "";
                        txtTelefono.Text = "";
                        txtEmail.Text = "";
                    }
                }
                
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Principal prin = new Principal();

            prin.Show();

            this.Hide();
        }

        private void bntEliminar_Click(object sender, EventArgs e)
        {
            EliminarCompañia compa = new EliminarCompañia();

            compa.ShowDialog();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
