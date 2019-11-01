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
    public partial class MantUni : FormMantenimiento
    {
        public MantUni()
        {
            InitializeComponent();
        }

        private void codigo_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(codigo.Text.Trim()))
                return;

            String CMD = String.Format("Select * From Unidades where CodUni='{0}'", codigo.Text.Trim());
            DS = Utilidades.Utilidades.Ejecutar(CMD);
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                nombre.Text = DS.Tables[0].Rows[0]["DesUni"].ToString().Trim();
                estado.Checked = Convert.ToBoolean(DS.Tables[0].Rows[0]["Status"].ToString().Trim());

            }
            else
            {
                nombre.Text = "";
                estado.Checked = false;

            }
        }

        public override void Salvar()
        {
            if (Utilidades.Utilidades.ValidarForm(this, errorProvider1))
            {
                String cmd = String.Format("Exec ActUnidades '{0}','{1}','{2}'", codigo.Text, nombre.Text, estado.Checked);
                DS = Utilidades.Utilidades.Ejecutar(cmd);
                if (DS != null)
                {
                    LimpiarCampos();
                    MessageBox.Show("Se guardo correctamente.");
                    Cancelar();

                }
                else
                {
                    MessageBox.Show("Error al guardar.");
                }
            }

        }
        
        public override void Consultar()
        {
            ConsUni obj = new ConsUni();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                codigo.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                codigo.Focus();
                SendKeys.Send("{TAB}");

            }


        }

        public void LimpiarCampos()
        {
            nombre.Text = "";
            estado.Checked = false;
            codigo.Text = "";
            codigo.Focus();

        }




    }
}
