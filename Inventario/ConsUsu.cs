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
    public partial class ConsUsu : Consultas
    {
        public ConsUsu()
        {
            InitializeComponent();
            Consultar();
            dataGridView1.AutoGenerateColumns = false;
        }


        public override void Consultar()
        {
            String CMD = "Select * From Usuarios";
            if (!String.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                CMD += " where Nombre  Like('%" + textBox1.Text.Trim() + "%')";
            }
            DS = Utilidades.Utilidades.Ejecutar(CMD);
            if (DS.Tables.Count > 0)
                dataGridView1.DataSource = DS.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                return;
            DialogResult = DialogResult.OK;
            Close();
        }



    }
}
