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
    public partial class RepCli : Form
    {
        public RepCli()
        {
            InitializeComponent();
        }

        private void RepCli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BD_InventarioDataSet.Clientes' table. You can move, or remove it, as needed.
            this.ClientesTableAdapter.Fill(this.BD_InventarioDataSet.Clientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
