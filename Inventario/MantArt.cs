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
                GruArt.Text = DS.Tables[0].Rows[0]["CodGru"].ToString().Trim();
                PunReo.Text = DS.Tables[0].Rows[0]["PunReo"].ToString().Trim();

            }
            else
            {
                nombre.Text = "";
                PreVen.Text = "";
                PreCom.Text = "";
                CanExi.Text = "0";
                CodDep.Text = "";
                CodSup.Text = "";
                CodUni.Text = "";
                PunReo.Text = "";
                GruArt.Text = "";
            }
        }

        public override void Salvar()
        {
            if (Utilidades.Utilidades.ValidarForm(this, errorProvider1))
            {
                return;
            }
            try
            {
                String cmd = String.Format("Exec ActArticulos '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}' ", codigo.Text, nombre.Text, PreVen.Text, PreCom.Text, CanExi.Text, CodDep.Text, CodSup.Text, CodUni.Text, GruArt.Text, PunReo.Text);
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
            catch(Exception AS) { }
        }

        void LimpiarCampos()
        {
            codigo.Text = "";
            nombre.Text = "";
            PreVen.Text = "";
            PreCom.Text = "";
            CanExi.Text = "0";
            CodDep.Text = "";
            CodSup.Text = "";
            CodUni.Text = "";
            PunReo.Text = "";
            GruArt.Text = "";
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

        private void ConsGruArt_Click(object sender, EventArgs e)
        {
            ConsGruArt obj = new ConsGruArt();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                GruArt.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void ConsDep_Click(object sender, EventArgs e)
        {
            ConsDep obj = new ConsDep();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                CodDep.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void ConsSup_Click(object sender, EventArgs e)
        {
            ConsSup obj = new ConsSup();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                CodSup.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void ConsUni_Click(object sender, EventArgs e)
        {
            ConsUni obj = new ConsUni();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                CodUni.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            }
        }
    }


    }
