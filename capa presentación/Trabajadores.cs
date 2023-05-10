using Cooperativa_Julian_vega_felix.modelado;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            txtNombre.Focus();
            // Verifica si todos los campos están llenos
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtCurp.Text) || string.IsNullOrEmpty(txtRfc.Text))
            {
                MessageBox.Show("Por favor rellene los campos faltantes", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (var dt = new PruebaContext())
                {
                    // Verifica si el número de teléfono ya está registrado
                    if (dt.Trabajadores.Any(t => t.TelTra == txtTelefono.Text))
                    {
                        MessageBox.Show("El número de teléfono ya está registrado", "Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    // Verifica si el RFC ya está registrado
                    else if (dt.Trabajadores.Any(t => t.Rfc == txtRfc.Text))
                    {
                        MessageBox.Show("El RFC ya está registrado", "Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    // Verifica si la CURP ya está registrada
                    else if (dt.Trabajadores.Any(t => t.Curp == txtCurp.Text))
                    {
                        MessageBox.Show("La CURP ya está registrada", "Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // Registra el trabajador
                        Trabajadore trabajador = new Trabajadore();
                        trabajador.NomTra = txtNombre.Text;
                        trabajador.ApelTra = txtApellido.Text;
                        trabajador.TelTra = txtTelefono.Text;
                        trabajador.Rfc = txtRfc.Text;
                        trabajador.Curp = txtCurp.Text;

                        dt.Trabajadores.Add(trabajador);
                        dt.SaveChanges();

                        MessageBox.Show("Trabajador registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        // Limpia los campos de entrada de texto y refresca la tabla de trabajadores
                        txtNombre.Text = "";
                        txtApellido.Text = "";
                        txtTelefono.Text = "";
                        txtRfc.Text = "";
                        txtCurp.Text = "";
                        refrescar();
                        ConfigurarDataGridView();
                        
                    }
                }
            }

        }

        private void txtRfc_TextChanged(object sender, EventArgs e)
        {
            txtRfc.MaxLength = 16;
        }

        private void txtRfc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtCurp.Focus();
            }
        }

        private void txtCurp_TextChanged(object sender, EventArgs e)
        {
            txtCurp.MaxLength = 18;
        }

        private void txtCurp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar si el carácter ingresado es un número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es un número ni una tecla de retroceso, cancelar el evento
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtRfc.Focus();
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
            


            comboBox1.Items.Add("Limpieza");
            comboBox1.Items.Add("resaga");
            comboBox1.Items.Add("bomba");
        }
        public void cambio()
        {
            dataGridView1.Columns[0].HeaderText = "ID Trabajo";

            dataGridView1.Columns[1].HeaderText = "Nombre Del Trabajador";
            dataGridView1.Columns[2].HeaderText = "Apellido Del Trabajador";
            dataGridView1.Columns[3].HeaderText = "Telefono";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

            txtNombre.Focus();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            refrescar();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true; 
            }
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtApellido.Focus();
            }

        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnprovedor_Click(object sender, EventArgs e)
        {
            //OcultarPesonal();
            

            //ocultar labels




            

        }

        public void OcultarPesonal()
        {
            lblNombre.Visible = true;
            lblApellido.Visible = true;
            lblTelefono.Visible = true;
            lblRFC.Visible = true;
            lblCurp.Visible = true;



            txtNombre.Visible = true;
            txtApellido.Visible = true;
            txtTelefono.Visible = true;
            txtRfc.Visible = true;
            txtCurp.Visible = true;



            btnAgregar.Visible = true;
            
            bntEliminar.Visible = true;

            //labels
            lblPersonal.Visible = false;
            lblApellidoPersonal.Visible = false;
            lblTipo.Visible = false;
            lblNombrePersonal.Visible = false;
            lblTelefonoPersonal.Visible = false;
            lblRFCPersonal.Visible = false;
            lblCurpPersonal.Visible = false;

            //texts
            txtTelefonoPersonal.Visible = false;
            txtNombrePersonal.Visible = false;
            txtApellidoPersonal.Visible = false;
            txtRfcPersonal.Visible = false;
            lblCurpPersonal.Visible = false;
            comboBox1.Visible = false;
            txtCurpPersonal.Visible = false;

            //button 
            btnAgregarPersonal.Visible = false;

        }
        private void btnpersonal_Click(object sender, EventArgs e)
        {


            // OcultarProovedores();

           
        }

        public void RefrescarPersonal()
        {
            var personal = dt.Personals.ToList();

            dataGridView1.DataSource = personal;

            dataGridView1.Columns[0].HeaderText = "ID Personal";
            dataGridView1.Columns[1].HeaderText = "ID Area";
            dataGridView1.Columns[2].HeaderText = "Nombre";
            dataGridView1.Columns[3].HeaderText = "Apellido";
            dataGridView1.Columns[4].HeaderText = "Telefono";
            dataGridView1.Columns[5].HeaderText = "RFC";
            dataGridView1.Columns[6].HeaderText = "CURP";

            ConfigurarDataGridView();

        }

        public void OcultarProovedores()
        {
            lblTrabajadores.Visible = false;
            lblApellidoPersonal.Visible = true;
            lblTipo.Visible = true;
            lblNombrePersonal.Visible = true;
            lblTelefonoPersonal.Visible = true;
            lblRFCPersonal.Visible = true;
            lblCurpPersonal.Visible = true;

            //texts
            txtTelefonoPersonal.Visible = true;
            txtNombrePersonal.Visible = true;
            txtApellidoPersonal.Visible = true;
            txtRfcPersonal.Visible = true;
            lblCurpPersonal.Visible = true;
            comboBox1.Visible = true;
            lblCurpPersonal.Visible = true;

            //button 
            btnAgregarPersonal.Visible = true;


            lblNombre.Visible = false;
            lblApellido.Visible = false;
            lblTelefono.Visible = false;
            lblRFC.Visible = false;
            lblCurp.Visible = false;

            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtTelefono.Visible = false;
            txtRfc.Visible = false;
            txtCurp.Visible = false;

            btnAgregar.Visible = false;
            
            bntEliminar.Visible = false;




        }

        private void lblCurp_Click(object sender, EventArgs e)
        {

        }

        private void lblRFC_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblpersonal_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarPersonal_Click(object sender, EventArgs e)
        {
            txtNombrePersonal.Focus();
            if (string.IsNullOrEmpty(txtNombrePersonal.Text) || string.IsNullOrEmpty(txtApellidoPersonal.Text) || string.IsNullOrEmpty(txtTelefonoPersonal.Text) || string.IsNullOrEmpty(txtCurpPersonal.Text) || string.IsNullOrEmpty(txtRfcPersonal.Text))
            {
                MessageBox.Show("Porfavor Rellene Los Campos Faltantes", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (var dt = new PruebaContext())
                {
                    if (dt.Personals.Any(p => p.TelPer == txtTelefonoPersonal.Text))
                    {
                        MessageBox.Show("Numero de telefono ya registrado", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (dt.Personals.Any(t => t.Rfc == txtRfcPersonal.Text))
                    {
                        MessageBox.Show("El RFC que ingreson ya esta registrado,", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (dt.Personals.Any(h => h.Curp == txtCurpPersonal.Text))
                    {
                        MessageBox.Show("La curp que ha ingresado ya esta registrada", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string opcionSeleccionada = comboBox1.SelectedItem.ToString().ToLower();
                        int valor = 0;

                        switch (opcionSeleccionada)
                        {
                            case "limpieza":
                                valor = 1;
                                break;
                            case "resaga":
                                valor = 2;
                                break;
                            case "bomba":
                                valor = 3;
                                break;
                            default:
                                // Asignar valor por defecto o manejar el caso de error
                                break;
                        }

                        // Utilizar la variable "valor" para insertar el valor en la base de datos

                        Personal persona = new Personal();
                        persona.IdAre = valor;
                        persona.NomPer = txtNombrePersonal.Text;
                        persona.ApePer = txtApellidoPersonal.Text;
                        persona.TelPer = txtTelefonoPersonal.Text;
                        persona.Rfc = txtRfcPersonal.Text;
                        persona.Curp = txtCurpPersonal.Text;

                        dt.Personals.Add(persona);
                        dt.SaveChanges();

                        MessageBox.Show("Empleado registrado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        txtNombrePersonal.Text = "";
                        txtApellidoPersonal.Text = "";
                        txtTelefonoPersonal.Text = "";
                        txtRfcPersonal.Text = "";
                        txtCurpPersonal.Text = "";

                        RefrescarPersonal();
                        ConfigurarDataGridView();

                        
                    }


                }

                

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void txtNombrePersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true; // Indica que se ha manejado el evento y que no debe propagarse más
            }

            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtApellidoPersonal.Focus();
            }
        }

        private void txtApellidoPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true; // Indica que se ha manejado el evento y que no debe propagarse más
            }

            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtTelefonoPersonal.Focus();

            }
        }

        private void txtTelefonoPersonal_TextChanged(object sender, EventArgs e)
        {
            txtTelefonoPersonal.MaxLength = 10;
        }

        private void txtTelefonoPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                // Si no es un número ni una tecla de retroceso, cancelar el evento
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtRfcPersonal.Focus();
            }
        }

        private void txtRfcPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtCurpPersonal.Focus();
            }
        }

        private void txtCurpPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                comboBox1.Focus();
            }

            if (e.KeyChar == 13) // Verifica si se presionó Enter
            {
                if (sender == txtCurpPersonal) // Verifica si el control activo es el TextBox1
                {
                    comboBox1.DroppedDown = true; // Abre la lista de opciones del ComboBox
                    e.Handled = true; // Indica que se ha manejado el evento y que no debe propagarse más
                }
                else if (sender == comboBox1) // Verifica si el control activo es el ComboBox1
                {
                    btnAgregarPersonal.Focus(); // Enfoca el siguiente control
                    e.Handled = true; // Indica que se ha manejado el evento y que no debe propagarse más
                }
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                btnAgregarPersonal.Focus();
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Principal prin = new Principal();

            prin.Show();

            this.Hide();
        }

        private void btnEliminarPersnonal_Click(object sender, EventArgs e)
        {
            eliminarPersonalId personal = new eliminarPersonalId();

            personal.ShowDialog();

            txtNombrePersonal.Focus();

            
        }

        private void txtRfcPersonal_TextChanged(object sender, EventArgs e)
        {
            txtRfcPersonal.MaxLength = 13;
        }

        private void txtCurpPersonal_TextChanged(object sender, EventArgs e)
        {
            txtCurpPersonal.MaxLength = 18;
        }

        private void btnAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                e.Handled = true;
                txtNombre.Focus();
            }
        }

        private void txtApellidoPersonal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            refrescar();


            cambio();

            txtNombre.Focus();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            txtNombrePersonal.Focus();
            RefrescarPersonal();
        }
    }
}
