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
    public partial class MantCliente : FormMantenimiento
    {
        public MantCliente()
        {
            InitializeComponent();
            
        }

        private void codigo_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(codigo.Text.Trim()))
                return;

            String CMD = String.Format("Select * From Clientes where CodCli='{0}'", codigo.Text.Trim());
            DS = Utilidades.Utilidades.Ejecutar(CMD);
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                nombre.Text = DS.Tables[0].Rows[0]["NomCli"].ToString().Trim();
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


        public override void Salvar()
        {
            if (Utilidades.Utilidades.ValidarForm(this, errorProvider1))
            {
                String cmd = String.Format("Exec ActClientes '{0}','{1}','{2}','{3}','{4}'", codigo.Text, nombre.Text, estado.Checked, email.Text,telefono.Text);
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

        public void LimpiarCampos()
        {
            nombre.Text = "";
            email.Text = "";
            telefono.Text = "";
            estado.Checked = false;
            codigo.Text = "";
            codigo.Focus();

        }
        
    }


    }
