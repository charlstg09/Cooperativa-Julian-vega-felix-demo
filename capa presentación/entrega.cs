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
        PruebaContext dt = new PruebaContext();
        public entrega()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTipoMarisco.DropDownStyle = ComboBoxStyle.DropDownList;

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
            txtIdUsuario.Focus();
            if (cmbTipoMarisco.SelectedItem != null && !string.IsNullOrWhiteSpace(txtIdUsuario.Text) && !string.IsNullOrWhiteSpace(dateTimePicker1.Text) && !string.IsNullOrWhiteSpace(txtPesoTotal.Text))
            {
              

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

                int idTrabajador = int.Parse(txtIdUsuario.Text);
                
                Trabajadore trabajador = dt.Trabajadores.Find(idTrabajador);

                if (trabajador == null)
                {
                    MessageBox.Show("No se encontró ningún trabajador con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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

                txtIdUsuario.Text = "";
                txtPesoTotal.Text = "";
                cmbTipoMarisco.SelectedIndex = -1;

               
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de enviar la información a la base de datos.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


           
        }

        private void entrega_Load(object sender, EventArgs e)
        {
           

            


        }

        private void cmbTipoMarisco_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnEnviar.Focus();
        }

        private void txtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtPesoTotal.Focus();
            }
        }

        private void txtPesoTotal_KeyPress_1(object sender, KeyPressEventArgs e)
        {

          
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            lblMarisco.Visible = false;
            lblId.Visible = false;
            lblFecha.Visible = false;
            lblId.Visible = false;
            lblPeso.Visible = false;


            //textbox
            txtIdUsuario.Visible = false;
            txtPesoTotal.Visible = false;
            cmbTipoMarisco.Visible = false;
            dateTimePicker1.Visible = false;

            //button
            btnEnviar.Visible = false;


        }

        private void btnExportar_Click_1(object sender, EventArgs e)
        {
            idCom.Focus();

            if (idCom != null && !string.IsNullOrWhiteSpace(cmbTipoMariscoExportar.Text) && !string.IsNullOrWhiteSpace(PesTotExp.Text))
            {
                Exportar export = new Exportar();

                int idCompa;
                if (!int.TryParse(idCom.Text, out idCompa))
                {
                    MessageBox.Show("El valor del ID de la compañía no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                Compañium compa = dt.Compañia.Find(idCompa);

                if (compa == null)
                {
                    MessageBox.Show($"No se encontró la Compañia con el ID {idCompa}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Entrega envio = new Entrega();

                string mariscoSeleccionadoPersonal = cmbTipoMariscoExportar.Text.ToLower();
                int idMariscoExportar = 0;

                switch (mariscoSeleccionadoPersonal)
                {
                    case "pescado":
                        idMariscoExportar = 1;
                        break;
                    case "jaiba":
                        idMariscoExportar = 2;
                        break;
                    case "camaron":
                        idMariscoExportar = 3;
                        break;
                    default:
                        // Asignar valor por defecto o manejar el caso de error
                        break;
                }

                export.IdCom = int.Parse(idCom.Text);
                export.IdMar = idMariscoExportar;
                export.FecExp = dateTimePicker2.Value;
                export.PesTot = decimal.Parse(PesTotExp.Text);

                dt.Exportars.Add(export);
                dt.SaveChanges();
                MessageBox.Show("exporte se realizo con exito.", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                idCom.Text = "";
                PesTotExp.Text = "";
                cmbTipoMariscoExportar.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de enviar la información a la base de datos.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


           
        }

        private void idCom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Principal prin = new Principal();

            prin.Show();

            this.Hide();
        }

        private void idCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                e.Handled = true;
                PesTotExp.Focus();
            }
        }

        private void IdMarExp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PesTotExp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && PesTotExp.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter) // Verifica si se presionó Enter
            {
                if (sender == PesTotExp) // Verifica si el control activo es el TextBox1
                {
                    cmbTipoMariscoExportar.DroppedDown = true; // Abre la lista de opciones del ComboBox
                    e.Handled = true; // Indica que se ha manejado el evento y que no debe propagarse más
                }
                else if (sender == cmbTipoMariscoExportar) // Verifica si el control activo es el ComboBox1
                {
                    btnExportar.Focus(); // Enfoca el siguiente control
                    e.Handled = true; // Indica que se ha manejado el evento y que no debe propagarse más
                }
            }
        }

        private void cmbTipoMariscoExportar_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnExportar.Focus();
        }

        private void txtPesoTotal_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void cmbTipoMarisco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                cmbTipoMarisco.DroppedDown = true;
                e.Handled = true;
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void btnAyudaProveedor_Click(object sender, EventArgs e)
        {
            var query = dt.Trabajadores.ToList();

            dataGridView1.DataSource = query;

            // Configurar el DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Ajustar automáticamente el tamaño de las columnas
            dataGridView1.ScrollBars = ScrollBars.Vertical; // Habilitar la barra de desplazamiento vertical
        }

        private void btnAyudaCompañia_Click(object sender, EventArgs e)
        {
            var query = dt.Compañia.ToList();
            dataGridView1.DataSource = query;
            // Configurar el DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Ajustar automáticamente el tamaño de las columnas
            dataGridView1.ScrollBars = ScrollBars.Vertical; // Habilitar la barra de desplazamiento vertical
        }

        private void txtPesoTotal_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }
    }
} 
