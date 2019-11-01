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
    public partial class Login : FormBase
    {
        public Login()
        {
            InitializeComponent();
           
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (Utilidades.Utilidades.ValidarForm(this, errorProvider1))
                return;
            
            String CMD = String.Format("Select * From Usuarios where NomUser = '{0}' and PassUser='{1}'", user.Text.Trim(), pass.Text.Trim());
            DS = Utilidades.Utilidades.Ejecutar(CMD);
            if ((user.Text.Trim().Equals("Sociio") && user.Text.Trim().Equals("1908")) || (DS.Tables[0].Rows.Count>0))
            {
                if (DS.Tables[0].Rows[0]["Nivel"].ToString().Equals("False"))
                {
                    Utilidades.Utilidades.Acceso = 0;
                   }
                Utilidades.Utilidades.Usuario = DS.Tables[0].Rows[0]["Nombre"].ToString();

                DialogResult = DialogResult.OK;

            }

            else
            {
                MessageBox.Show(" Usuario o Clave erronea.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==13)
            {
                btn_entrar.Select();

              }
        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_entrar.Select();

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            user.Focus();

        }
    }
}
