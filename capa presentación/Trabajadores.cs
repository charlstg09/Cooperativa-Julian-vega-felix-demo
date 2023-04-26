﻿using Cooperativa_Julian_vega_felix.modelado;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            refrescar();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtTelefono.Focus();
            }
        }

        private void btnprovedor_Click(object sender, EventArgs e)
        {
            OcultarPesonal();
            

            //ocultar labels




            refrescar();


            cambio();

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


            OcultarProovedores();


            RefrescarPersonal();
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
            if (string.IsNullOrEmpty(txtNombrePersonal.Text) || string.IsNullOrEmpty(txtApellidoPersonal.Text) || string.IsNullOrEmpty(txtTelefonoPersonal.Text) || string.IsNullOrEmpty(txtCurpPersonal.Text) || string.IsNullOrEmpty(txtRfcPersonal.Text))
            {
                MessageBox.Show("Porfavor Rellene Los Campos Faltantes", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                RefrescarPersonal();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void txtNombrePersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtApellidoPersonal.Focus();
            }
        }

        private void txtApellidoPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtTelefonoPersonal.Focus();

            }
        }

        private void txtTelefonoPersonal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefonoPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtRfcPersonal.Focus();
            }
        }

        private void txtRfcPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                txtCurpPersonal.Focus();
            }
        }

        private void txtCurpPersonal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                comboBox1.Focus();
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
    }
}
