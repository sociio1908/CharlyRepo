using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class ConsCli : Consultas
    {
        public ConsCli()
        {
            InitializeComponent();
            Consultar();
            dataGridView1.AutoGenerateColumns = false;
        }

        
        public override void Consultar()
        {
            String CMD = "Select * From Clientes ";
            if (!String.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                CMD += " where NomCli  Like('%" + textBox1.Text.Trim() + "%')";
            }
            DS = Utilidades.Utilidades.Ejecutar(CMD);
            if (DS.Tables.Count > 0)
                dataGridView1.DataSource = DS.Tables[0];
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                return;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Imprimir();
        }


        public override void Imprimir()
        {
            RepCli obj = new RepCli();
            obj.reportViewer1.LocalReport.DataSources[0].Value = DS.Tables[0];
            obj.ShowDialog();
            
         
        }




    }
}
