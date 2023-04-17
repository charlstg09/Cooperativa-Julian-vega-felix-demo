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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cooperativa_Julian_vega_felix.capa_presentación
{
   
    public partial class entrega : Form
    {
        PruebaContext dt;
        public entrega()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {
            txtIdUsuario.KeyPress += new KeyPressEventHandler(txtEntero_KeyPress);
        }

        // Evento KeyPress para TextBox de números enteros
        private void txtEntero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo caracteres numéricos y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Rechazar el carácter
            }
        }

        private void txtPesoTotal_TextChanged(object sender, EventArgs e)
        {
            txtPesoTotal.KeyPress += TxtPesoTotal_KeyPress;
        }

        private void TxtPesoTotal_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Permitir solo caracteres numéricos, la tecla de retroceso y el punto decimal
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true; // Rechazar el carácter
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (cmbTipoMarisco.SelectedItem != null && !string.IsNullOrWhiteSpace(txtIdUsuario.Text) && !string.IsNullOrWhiteSpace(dateTimePicker1.Text) && !string.IsNullOrWhiteSpace(txtPesoTotal.Text))
            {
                // Aquí puedes colocar el código para enviar los valores a la base de datos
                // utilizando los valores de los campos ComboBox, TextBox y DateTimePicker

                Entrega envio = new Entrega();

                string mariscoSeleccionado = cmbTipoMarisco.Text.ToLower();
                int idMarisco = 0;

                switch (mariscoSeleccionado)
                {
                    case "pescado":
                        idMarisco = 1;
                        break;
                    case "jaiba":
                        idMarisco = 2;
                        break;
                    case "camaron":
                        idMarisco = 3;
                        break;
                    default:
                        // Asignar valor por defecto o manejar el caso de error
                        break;
                }

                envio.IdMar = idMarisco;

                envio.IdTra = int.Parse(txtIdUsuario.Text);
                envio.PesTot = decimal.Parse(txtPesoTotal.Text);
                envio.FecEnt = dateTimePicker1.Value;

                dt.Entregas.Add(envio);
                dt.SaveChanges();





                MessageBox.Show("entrega se realizo con exito.", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Principal principal = new Principal();

                principal.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de enviar la información a la base de datos.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


           
        }

        private void entrega_Load(object sender, EventArgs e)
        {
            dt = new PruebaContext();

            


        }
    }
} 
