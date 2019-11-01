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
    public partial class MantDepartamento : FormMantenimiento

    {
        public MantDepartamento()
        {
            InitializeComponent();
        }

        private void Salir_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
        public override void Salvar()
        {
            if (Utilidades.Utilidades.ValidarForm(this, errorProvider1))
            {
                String cmd = String.Format("EXEC ActDepartamentos '{0}','{1}','{2}'", codigo.Text, nombre.Text, estado.Checked);
                DS = Utilidades.Utilidades.Ejecutar(cmd);
                if (DS != null)
                {
                    MessageBox.Show("Se guardo correctamente.");
                    Cancelar();
                }
                else
                {
                    MessageBox.Show("Error al guardar.");
                }
            }

        }
    }
}
