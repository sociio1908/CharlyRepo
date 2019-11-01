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
    public partial class FormProceso : FormBase
    {
        public FormProceso()
        {
            InitializeComponent();

        }

        private void Consultar_btn_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Cancelar_btn_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void Eliminar_btn_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void Imprimir_btn_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void Salvar_btn_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
