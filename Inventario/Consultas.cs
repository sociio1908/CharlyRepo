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
    public partial class Consultas : FormBase
    {
        public Consultas()
        {
            InitializeComponent();
           
        }

        private void Consultar_btn_Click(object sender, EventArgs e)
        {
            Consultar();
        }

    }
}
