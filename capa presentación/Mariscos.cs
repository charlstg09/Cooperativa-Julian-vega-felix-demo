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
    public partial class Mariscos : Form
    {
        private PruebaContext dt = new PruebaContext();
        public Mariscos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Mariscos_Load(object sender, EventArgs e)
        {
            Actualizar();

        }

        private void Actualizar()
        {
            var x = dt.Mariscos.ToList();
            dataGridView1.DataSource = x;


            cambio();
        }
        public void cambio()
        {
            dataGridView1.Columns[0].HeaderText = "ID Del marisco";

            dataGridView1.Columns[1].HeaderText = "Nombre del marisco";
            dataGridView1.Columns[2].HeaderText = "Sub tipo de marisco";
            dataGridView1.Columns[3].HeaderText = "Precio";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtNombre.Focus();
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtSubtipo.Text) || string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Porfavor rellene todos los campos", "Campos Imcompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Marisco mari = new Marisco();

                mari.TipMariscos = txtNombre.Text;
                mari.SubTipoMarisco = txtSubtipo.Text;
                mari.PrecioMarisco = decimal.Parse(txtPrecio.Text);

                dt.Mariscos.Add(mari);
                dt.SaveChanges();


                MessageBox.Show("Marisco agregado con exito", "Exito" , MessageBoxButtons.OK);
                Actualizar();

                txtNombre.Text = "";
                txtSubtipo.Text = "";
                txtPrecio.Text = "";

                


            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtSubtipo.Focus();
            }
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSubtipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled= true;
                txtPrecio.Focus();
            }

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                btnAgregar.Focus();
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                // Si no es un número, una tecla de retroceso o un punto decimal, cancelar el evento
                e.Handled = true;
            }

        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtNuevoValor.Focus();

            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es un número ni una tecla de retroceso, cancelar el evento
                e.Handled = true;
            }
        }

        private void txtNuevoValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                BtnModificar.Focus();
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                // Si no es un número, una tecla de retroceso o un punto decimal, cancelar el evento
                e.Handled = true;
            }

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            txtId.Focus();
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNuevoValor.Text))
            {
                MessageBox.Show("Porfavor Complete los valores faltantes", "Valores incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int Idmarisco = int.Parse(txtId.Text);

               Marisco BuscarMarisco = dt.Mariscos.Find(Idmarisco);

                if (BuscarMarisco == null)
                {
                    MessageBox.Show("No se encontró ningún marisco con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    BuscarMarisco.PrecioMarisco = decimal.Parse(txtNuevoValor.Text);
                    dt.SaveChanges();
                    MessageBox.Show($"Se ha realizado con exito la modificación del precio del marisco con Id: {Idmarisco}.", "Exito", MessageBoxButtons.OK);
                    Actualizar();

                    txtId.Text = "";
                
                    txtNuevoValor.Text = "";
                }
            }
            
        }
    }
}
