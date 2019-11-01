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
    public partial class MantArt : FormMantenimiento
    {
        public MantArt()
        {
            InitializeComponent();
            codigo.Focus();
        }

        private void codigo_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(codigo.Text.Trim()))
                return;

            String CMD = String.Format("Select * From Articulos where CodArt='{0}'", codigo.Text.Trim());
            DS = Utilidades.Utilidades.Ejecutar(CMD);
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                nombre.Text = DS.Tables[0].Rows[0]["NomArt"].ToString().Trim();
                PreVen.Text = DS.Tables[0].Rows[0]["PreVen"].ToString().Trim();
                PreCom.Text = DS.Tables[0].Rows[0]["PreCom"].ToString().Trim();
                CanExi.Text = DS.Tables[0].Rows[0]["CanExi"].ToString().Trim();
                CodDep.Text = DS.Tables[0].Rows[0]["CodDep"].ToString().Trim();
                CodSup.Text = DS.Tables[0].Rows[0]["CodSup"].ToString().Trim();
                CodUni.Text = DS.Tables[0].Rows[0]["CodUni"].ToString().Trim();
                PunReo.Text = DS.Tables[0].Rows[0]["PunReo"].ToString().Trim();

            }
            else
            {
                nombre.Text = "";
                PreVen.Text = "";
                PreCom.Text = "";
                CanExi.Text = "";
                CodDep.Text = "";
                CodSup.Text = "";
                CodUni.Text = "";
                PunReo.Text = "";

            }
        }

        public override void Salvar()
        {
            if (Utilidades.Utilidades.ValidarForm(this, errorProvider1))
            {

                String cmd = String.Format("Exec ActArticulos '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}' ", codigo.Text, nombre.Text, PreVen.Text, PreCom.Text, CanExi.Text, CodDep.Text, CodSup.Text, CodUni.Text, PunReo.Text);
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

        void LimpiarCampos()
        {
            codigo.Text = "";
            nombre.Text = "";
            PreVen.Text = "";
            PreCom.Text = "";
            CanExi.Text = "";
            CodDep.Text = "";
            CodSup.Text = "";
            CodUni.Text = "";
            PunReo.Text = "";
        }

        public override void Consultar()
        {
            ConsArt obj = new ConsArt();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                codigo.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                codigo.Focus();
                SendKeys.Send("{TAB}");

            }


        }


    }


    }
