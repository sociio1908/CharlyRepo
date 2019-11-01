using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class ReporteProceso : Form
    {
        public ReporteProceso()
        {
            InitializeComponent();
        }

        private void ReporteProceso_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BD_InventarioDataSet2.Ventas' table. You can move, or remove it, as needed.
            this.VentasTableAdapter.Fill(this.BD_InventarioDataSet2.Ventas);

            this.reportViewer1.RefreshReport();
        }
    }
}
