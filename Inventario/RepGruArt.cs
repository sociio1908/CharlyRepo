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
    public partial class RepGruArt : Form
    {
        public RepGruArt()
        {
            InitializeComponent();
        }

        private void RepGruArt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BD_InventarioDataSet.Clientes' table. You can move, or remove it, as needed.
      
            this.reportViewer1.RefreshReport();
        }

        private void RepGruArt_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GrupoArticulos.GruposArticulos' table. You can move, or remove it, as needed.
            this.GruposArticulosTableAdapter.Fill(this.GrupoArticulos.GruposArticulos);

            this.reportViewer2.RefreshReport();
        }
    }
}
