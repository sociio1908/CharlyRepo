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
    public partial class FormMantenimiento : FormBase
    {
        public FormMantenimiento()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
    }
}
