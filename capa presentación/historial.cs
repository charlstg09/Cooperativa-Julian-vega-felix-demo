﻿using Cooperativa_Julian_vega_felix.modelado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Cooperativa_Julian_vega_felix.capa_presentación
{
    public partial class historial : Form
    {
        PruebaContext dt = new PruebaContext();
        public historial()
        {
            InitializeComponent();
            dt = new PruebaContext();
        }

        private void chkId_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void historial_Load(object sender, EventArgs e)
        {
           
        }

        public void refrescar()
        {
            var query = dt.Entregas.ToList();

            dataGridView1.DataSource = query;
            configurarDataGridView();

        }

        public void configurarDataGridView()
        {
            // Configurar el DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Ajustar automáticamente el tamaño de las columnas
            dataGridView1.ScrollBars = ScrollBars.Vertical; // Habilitar la barra de desplazamiento vertical
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        public void ConfigurarTablaProovedor()
        {

            configurarDataGridView();
            dataGridView1.Columns[0].HeaderText = "ID Entrega";
            dataGridView1.Columns[1].HeaderText = "ID Mariscos";
            dataGridView1.Columns[2].HeaderText = "ID Empleado";
            dataGridView1.Columns[3].HeaderText = "Fecha Entrega";
            dataGridView1.Columns[4].HeaderText = "Peso Total";
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            refrescar();

            ConfigurarTablaProovedor();
        }

        public void ConfigurarTablaExportar()
        {
            dataGridView1.Columns[0].HeaderText = "ID Exporte";
            dataGridView1.Columns[1].HeaderText = "ID Compañia";
            dataGridView1.Columns[2].HeaderText = "ID Marisco";
            dataGridView1.Columns[4].HeaderText = "Fecha";
            dataGridView1.Columns[3].HeaderText = "Peso Total";
        }

        private void btnproovedores_Click(object sender, EventArgs e)
        {
            var query = dt.Exportars.ToList();
            dataGridView1.DataSource = query;
            

            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdProovedor.Text) && cmbTipoMarisco.SelectedIndex < 0)
            {
                // Si no hay nada en el TextBox ni en el ComboBox, mostrar mensaje de error
                MessageBox.Show("Ingrese un Id de compañía o seleccione un marisco.");
                return;
            }
            if (!string.IsNullOrEmpty(txtIdProovedor.Text))
            {
                // Si hay texto en el TextBox, intentar convertirlo a un entero
                if (!int.TryParse(txtIdProovedor.Text, out int idPersonal))
                {
                    // Si no se puede convertir a un entero, mostrar mensaje de error
                    MessageBox.Show("Ingrese un Id de compañía válido.");
                    return;
                }

                // Consultar si hay exportaciones con el idCompañia ingresado
                using (var context = new PruebaContext())
                {
                    var entregas = context.Entregas.Where(e => e.IdTra == idPersonal).ToList();

                    if (entregas.Count > 0)
                    {
                        // Si hay exportaciones con el idCompañia ingresado, ordenar el DataGridView
                        dataGridView1.DataSource = entregas.OrderBy(e => e.FecEnt).ToList();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron exportaciones con el Id de compañía ingresado.");
                    }
                }

                // Limpiar el TextBox
                txtIdProovedor.Text = string.Empty;
            }
            else
            {
                // Si no hay texto en el TextBox, obtener el valor seleccionado en el ComboBox
                string mariscoSeleccionado = cmbTipoMarisco.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(mariscoSeleccionado))
                {
                    // Si no se ha seleccionado un marisco, mostrar mensaje de error
                    MessageBox.Show("Seleccione un marisco o ingrese un Id de compañía");
                    return;
                }

                // Obtener el ID del marisco seleccionado en la base de datos
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
                }

                // Consultar si hay exportaciones con el marisco seleccionado
                using (var context = new PruebaContext())
                {
                    var entregas = context.Entregas.Where(e => e.IdMar == idMarisco).ToList();
                    if (entregas.Count > 0)
                    {
                        // Si hay exportaciones con el marisco seleccionado, ordenar el DataGridView
                        dataGridView1.DataSource = entregas.OrderBy(e => e.FecEnt).ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No hay exportaciones de {mariscoSeleccionado}.");
                    }
                }

                // Limpiar el ComboBox
                cmbTipoMarisco.SelectedIndex = -1;
            }

        }


        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkDia_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkTIpoMarisco_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Principal prin = new Principal();

            prin.Show();

            this.Hide();
        }

        private void btnhoyPersonal_Click(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;

            // Obtener las entregas de hoy
            var entregas = dt.Entregas
                .Where(p => p.FecEnt == fechaActual)
                .ToList();

            // Asignar los datos al DataGridView
            dataGridView1.DataSource = entregas;

            // Actualizar la vista del DataGridView
           dataGridView1.Refresh();
            ConfigurarTablaProovedor();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;

            // Obtener las entregas de hoy
            var export = dt.Exportars
                .Where(p => p.FecExp == fechaActual)
                .ToList();

            // Asignar los datos al DataGridView
            dataGridView1.DataSource = export;

            // Actualizar la vista del DataGridView
            dataGridView1.Refresh();

            ConfigurarTablaExportar();
        }

        private void cmbTipoMarisco_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtIdProovedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompañia.Text) && cmbMariscoExportar.SelectedIndex < 0)
            {
                // Si no hay nada en el TextBox ni en el ComboBox, mostrar mensaje de error
                MessageBox.Show("Ingrese un Id de compañía o seleccione un marisco.");
                return;
            }

            if (!string.IsNullOrEmpty(txtCompañia.Text))
            {
                // Si hay texto en el TextBox, intentar convertirlo a un entero
                if (!int.TryParse(txtCompañia.Text, out int idCompañia))
                {
                    // Si no se puede convertir a un entero, mostrar mensaje de error
                    MessageBox.Show("Ingrese un Id de compañía válido.");
                    return;
                }

                // Consultar si hay exportaciones con el idCompañia ingresado
                using (var context = new PruebaContext())
                {
                    var exportaciones = context.Exportars.Where(e => e.IdCom == idCompañia).ToList();
                    if (exportaciones.Count > 0)
                    {
                        // Si hay exportaciones con el idCompañia ingresado, ordenar el DataGridView
                        dataGridView1.DataSource = exportaciones.OrderBy(e => e.FecExp).ToList();
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron exportaciones con el Id de compañía ingresado.");
                    }
                }

                // Limpiar el TextBox
                txtCompañia.Text = string.Empty;
            }
            else
            {
                // Si no hay texto en el TextBox, obtener el valor seleccionado en el ComboBox
                string mariscoSeleccionado = cmbMariscoExportar.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(mariscoSeleccionado))
                {
                    // Si no se ha seleccionado un marisco, mostrar mensaje de error
                    MessageBox.Show("Seleccione un marisco o ingrese un Id de compañía");
                    return;
                }

                // Obtener el ID del marisco seleccionado en la base de datos
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
                }

                // Consultar si hay exportaciones con el marisco seleccionado
                using (var context = new PruebaContext())
                {
                    var exportaciones = context.Exportars.Where(e => e.IdMar == idMarisco).ToList();
                    if (exportaciones.Count > 0)
                    {
                        // Si hay exportaciones con el marisco seleccionado, ordenar el DataGridView
                        dataGridView1.DataSource = exportaciones.OrderBy(e => e.FecExp).ToList();
                    }
                    else
                    {
                        MessageBox.Show($"No hay exportaciones de {mariscoSeleccionado}.");
                    }
                }

                // Limpiar el ComboBox
                cmbMariscoExportar.SelectedIndex = -1;
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dateTimePicker1.Value.Date;

            // Obtener las entregas de la fecha seleccionada
            var export = dt.Entregas
                .Where(p => p.FecEnt == fechaSeleccionada)
                .ToList();

            // Asignar los datos al DataGridView
            dataGridView1.DataSource = export;

            // Actualizar la vista del DataGridView
            dataGridView1.Refresh();

            ConfigurarTablaProovedor();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dateTimePicker2.Value.Date;

            // Obtener las entregas de la fecha seleccionada
            var export = dt.Exportars
                .Where(p => p.FecExp == fechaSeleccionada)
                .ToList();

            // Asignar los datos al DataGridView
            dataGridView1.DataSource = export;

            // Actualizar la vista del DataGridView
            dataGridView1.Refresh();
            ConfigurarTablaExportar();


        }

       
    }
}
