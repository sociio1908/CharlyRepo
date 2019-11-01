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
    public partial class MantSup : FormMantenimiento
    {
        public MantSup()
        {
            InitializeComponent();
            
        }



        public override void Salvar()
        {
            if (Utilidades.Utilidades.ValidarForm(this, errorProvider1))
            {
                return;
            }

                String cmd = String.Format("Exec ActSuplidores '{0}','{1}','{2}','{3}','{4}'", codigo.Text, nombre.Text, estado.Checked, email.Text, telefono.Text);
                DS = Utilidades.Utilidades.Ejecutar(cmd);
                if (DS != null)
                {
                    LimpiarCampos();
                    MessageBox.Show("Se guardo correctamente.");
                  
                }
                else
                {
                    MessageBox.Show("Error al guardar.");
                }
            
        }

        public void LimpiarCampos()
        {
            nombre.Text = "";
            email.Text = "";
            telefono.Text = "";
            estado.Checked = false;
            codigo.Text = "";
            codigo.Focus();

        }

        public override void Consultar()
        {
            ConsSup obj = new ConsSup();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                codigo.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                codigo.Focus();
                SendKeys.Send("{TAB}");

            }


        }

        private void codigo_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(codigo.Text.Trim()))
                return;

            String CMD = String.Format("Select * From Suplidores where CodSup='{0}'", codigo.Text.Trim());
            DS = Utilidades.Utilidades.Ejecutar(CMD);
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                nombre.Text = DS.Tables[0].Rows[0]["NomSup"].ToString().Trim();
                email.Text = DS.Tables[0].Rows[0]["Email"].ToString().Trim();
                telefono.Text = DS.Tables[0].Rows[0]["Telefono"].ToString().Trim();
                estado.Checked = Convert.ToBoolean(DS.Tables[0].Rows[0]["Status"].ToString().Trim());

            }
            else
            {
                nombre.Text = "";
                email.Text = "";
                telefono.Text = "";
                estado.Checked = false;

            }
        }



    }
}
