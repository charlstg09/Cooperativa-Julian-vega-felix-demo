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
        public historial()
        {
            InitializeComponent();
        }

        private void chkId_CheckedChanged(object sender, EventArgs e)
        {
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
    }
}
