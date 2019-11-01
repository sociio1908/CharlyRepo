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
    public partial class MantUsu : FormMantenimiento
    {
        public MantUsu()
        {
            InitializeComponent();
        }

        private void codigo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(codigo.Text.Trim()))
                    return;
                String CMD = String.Format("Select * FROM Usuarios where CodUsu = '{0}'", codigo.Text.Trim());
                DS = Utilidades.Utilidades.Ejecutar(CMD);
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    nombre.Text = DS.Tables[0].Rows[0]["Nombre"].ToString().Trim();
                    usuario.Text = DS.Tables[0].Rows[0]["NomUser"].ToString().Trim();
                    pass.Text = DS.Tables[0].Rows[0]["PassUser"].ToString().Trim();
                    if (DS.Tables[0].Rows[0]["Nivel"].ToString().Trim().Equals("False"))
                    {
                        c_nivel.SelectedIndex = 0;
                    }
                    else
                    {
                        c_nivel.SelectedIndex = 1;
                    }

                }
                else
                {
                    nombre.Text = "";
                    usuario.Text = "";
                    pass.Text = "";
                    c_nivel.Text = "Seleccione...";

                }
            }catch (Exception ea)
            {
                MessageBox.Show("Erro: " + ea);
            }

        }


        public override void Salvar()
        {
            try
            {
                if (Utilidades.Utilidades.ValidarForm(this, errorProvider1))
                    return;
                if (c_nivel.SelectedIndex >= 0)
                {
                    String CMD = String.Format("EXEC ActUsuarios '{0}','{1}','{2}','{3}','{4}'", codigo.Text.Trim(), nombre.Text.Trim(), usuario.Text.Trim(), pass.Text.Trim(), c_nivel.SelectedIndex);
                    DS = Utilidades.Utilidades.Ejecutar(CMD);

                    if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                    {
                        LimpiarCampos();
                        MessageBox.Show("Datos guardados correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar.");
                    }
                }
                else
                {
                    MessageBox.Show("SELECCIONE EL NIVEL DE ACCESO.");
                }

            }
            catch (Exception e){  MessageBox.Show("Erro: "+e);
            }

            }

        void LimpiarCampos()
        {
            nombre.Text = "";
            usuario.Text = "";
            pass.Text = "";
            codigo.Text = "";
            c_nivel.Text = "Seleccione...";
        }


        public override void Consultar()
        {
            ConsUsu obj = new ConsUsu();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                codigo.Text = obj.dataGridView1.Rows[obj.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
                codigo.Focus();
                SendKeys.Send("{TAB}");
            }
        }


    }
}
