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
    public partial class RepSup : Form
    {
        public RepSup()
        {
            InitializeComponent();
        }

        private void RepSup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BD_InventarioDataSet.Suplidores' table. You can move, or remove it, as needed.
            this.SuplidoresTableAdapter.Fill(this.BD_InventarioDataSet.Suplidores);

            this.reportViewer1.RefreshReport();
        }
    }
}
