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
    public partial class RepArt : Form
    {
        public RepArt()
        {
            InitializeComponent();
        }
        
        private void RepArt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BD_InventarioDataSet.Articulos' table. You can move, or remove it, as needed.
            this.ArticulosTableAdapter.Fill(this.BD_InventarioDataSet.Articulos);
            this.reportViewer1.RefreshReport();
        }

        private void ArticulosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
