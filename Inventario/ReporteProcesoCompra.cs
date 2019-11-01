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
    public partial class ReporteProcesoCompra : Form
    {
        public ReporteProcesoCompra()
        {
            InitializeComponent();
        }

        private void ReporteProcesoCompra_Load(object sender, EventArgs e)
        {
           this.ComprasTableAdapter.Fill(this.BD_InventarioDataSet2.Compras);
            this.reportViewer1.RefreshReport();
        }
    }
}
