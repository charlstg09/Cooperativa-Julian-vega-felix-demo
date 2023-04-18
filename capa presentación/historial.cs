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
    public partial class historial : Form
    {
        PruebaContext dt;
        public historial()
        {
            InitializeComponent();
            dt = new PruebaContext();
        }

        private void chkId_CheckedChanged(object sender, EventArgs e)
        {
            chkId.Checked = false;
            if (chkId.Checked)
            {
                txtId.Visible = true;

                lblId.Visible = true;
            }
            else
            {
                txtId.Visible = false;

                lblId.Visible = false;
            }
        }

        private void historial_Load(object sender, EventArgs e)
        {
            refrescar();

            cambio();
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

        public void cambio()
        {
            // Cambiar el nombre de las columnas en un DataGridView por índice de columna
            dataGridView1.Columns[0].HeaderText = "ID Entrega";
            dataGridView1.Columns[1].HeaderText = "ID Mariscos";
            dataGridView1.Columns[2].HeaderText = "ID Empleado";
            dataGridView1.Columns[3].HeaderText = "Fecha Entrega";
            dataGridView1.Columns[4].HeaderText = "Peso Total";
        }
    }
}
