using System;
using System.Windows.Forms;

namespace Inventario
{
    public partial class ConsArt : Consultas
    {
        public ConsArt()
        {
            InitializeComponent();
            Consultar();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                return;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        String CMD = "";
        public override void Consultar()
        {
            CMD = "SELECT * FROM Articulos";
            if (!String.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                CMD += " WHERE NomArt Like('%" + textBox1.Text.Trim() + "%')";
            }
            DS = Utilidades.Utilidades.Ejecutar(CMD);
            if (DS.Tables.Count > 0)
                dataGridView1.DataSource = DS.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        public override void Imprimir()
        {
            RepArt obj = new RepArt();
            obj.reportViewer1.LocalReport.DataSources[0].Value = DS.Tables[0];
            obj.ShowDialog();
            
        }
    }
}
