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
    public partial class ConsGruArt : Consultas
    {
        public ConsGruArt()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            Consultar();
        }

        public override void Consultar()
        {
            String CMD = "Select * From GruposArticulos";
            if (!String.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                CMD += " where NomGru  Like('%" + textBox1.Text.Trim() + "%')";
            }

            DS = Utilidades.Utilidades.Ejecutar(CMD);
            if (DS.Tables.Count > 0)
                dataGridView1.DataSource = DS.Tables[0];


        }

        public override void Imprimir()
        {
            RepGruArt obj = new RepGruArt();
            obj.reportViewer2.LocalReport.DataSources[0].Value = DS.Tables[0];
            obj.ShowDialog();
        }



        private void button5_Click(object sender, EventArgs e)
        {
            Imprimir();
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
