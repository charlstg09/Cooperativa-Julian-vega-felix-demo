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
            refrescar();

            cambio();
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
            //ocultar labels
            lblNombre.Visible = false;
            lblApellido.Visible = false;
            lblTelefono.Visible = false;
            lblRFC.Visible = false;
            lblCurp.Visible = false;

            //ocultar textboxs

            txtNombre.Visible = false;
            txtApellido.Visible = false;
            txtTelefono.Visible = false;
            txtRfc.Visible = false;
            txtCurp.Visible = false;


            //ocultar botones
            btnAgregar.Visible = false;
            button1.Visible = false;
            bntEliminar.Visible = false;

        }

        private void btnpersonal_Click(object sender, EventArgs e)
        {
            //ocultar labels
            lblNombre.Visible = true;
            lblApellido.Visible = true;
            lblTelefono.Visible = true;
            lblRFC.Visible = true;
            lblCurp.Visible = true;

            //ocultar textboxs

            txtNombre.Visible = true;
            txtApellido.Visible = true;
            txtTelefono.Visible = true;
            txtRfc.Visible = true;
            txtCurp.Visible = true;


            //ocultar botones
            btnAgregar.Visible = true;
            button1.Visible = true;
            bntEliminar.Visible = true;
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
                
            }
        }
    }
}
