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
            string idCompañiaTexto = txtCompañia.Text;
            if (!string.IsNullOrEmpty(idCompañiaTexto))
            {
                int idExport;
                if (int.TryParse(idCompañiaTexto, out idExport))
                {
                    using (var context = new PruebaContext())
                    {
                        var exportaciones = context.Exportars.Where(e => e.IdCom == idExport).ToList();
                        if (exportaciones.Count > 0)
                        {
                            // Si hay exportaciones con el idCompañia ingresado, ordenar el datagridview
                            dataGridView1.DataSource = exportaciones.OrderBy(e => e.FecExp).ToList();
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron exportaciones con el idCompañia ingresado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El valor ingresado no es un número válido.");
                }
            }
            else if (cmbMariscoExportar.SelectedIndex >= 0)
            {
                // Obtener el valor seleccionado en el ComboBox
                string mariscoSeleccionado = cmbMariscoExportar.SelectedItem.ToString();

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
                var exportaciones = dt.Exportars.Where(p => p.IdMar == idMarisco).ToList();

                if (exportaciones.Count == 0)
                {
                    // Si no hay exportaciones con el marisco seleccionado, mostrar un mensaje
                    MessageBox.Show("No hay exportaciones de: " + mariscoSeleccionado);
                }
                else
                {
                    // Si hay exportaciones con el marisco seleccionado, ordenar y mostrar en el DataGridView
                    exportaciones = exportaciones.OrderBy(p => p.FecExp).ToList(); // Ordenar por fecha de entrega
                    dataGridView1.DataSource = exportaciones;
                    dataGridView1.Refresh();
                }
            }
            else
            {
                // Si no hay nada seleccionado, mostrar un mensaje
                MessageBox.Show("Seleccione un marisco o ingrese un Id de compañía");
            }
            ConfigurarTablaProovedor();

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
            string idCompañiaTexto = txtCompañia.Text;
            if (!string.IsNullOrEmpty(idCompañiaTexto))
            {
                int idExport;
                if (int.TryParse(idCompañiaTexto, out idExport))
                {
                    using (var context = new PruebaContext())
                    {
                        var exportaciones = context.Exportars.Where(e => e.IdCom == idExport).ToList();
                        if (exportaciones.Count > 0)
                        {
                            // Si hay exportaciones con el idCompañia ingresado, ordenar el datagridview
                            dataGridView1.DataSource = exportaciones.OrderBy(e => e.FecExp).ToList();
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron exportaciones con el idCompañia ingresado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El valor ingresado no es un número válido.");
                }
            }
            else if (cmbMariscoExportar.SelectedIndex >= 0)
            {
                // Obtener el valor seleccionado en el ComboBox
                string mariscoSeleccionado = cmbMariscoExportar.SelectedItem.ToString();

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
                var exportaciones = dt.Exportars.Where(p => p.IdMar == idMarisco).ToList();

                if (exportaciones.Count == 0)
                {
                    // Si no hay exportaciones con el marisco seleccionado, mostrar un mensaje
                    MessageBox.Show("No hay exportaciones de: " + mariscoSeleccionado);
                }
                else
                {
                    // Si hay exportaciones con el marisco seleccionado, ordenar y mostrar en el DataGridView
                    exportaciones = exportaciones.OrderBy(p => p.FecExp).ToList(); // Ordenar por fecha de entrega
                    dataGridView1.DataSource = exportaciones;
                    dataGridView1.Refresh();
                }
            }
            else
            {
                // Si no hay nada seleccionado, no hacer nada
                MessageBox.Show("Seleccione un marisco o ingrese un Id de compañía");
            }
            ConfigurarTablaExportar();

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
