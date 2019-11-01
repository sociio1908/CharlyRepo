using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class ConsultarVentaCompra : Consultas
    {
        public ConsultarVentaCompra(String Tipo_consulta)
        {
            InitializeComponent();
            tabla = Tipo_consulta;
            if (Tipo_consulta.Equals("Compras"))
            {
                Campo = "CodSup";
            }
            else if (Tipo_consulta.Equals("Ventas"))
            {
                Campo = "CodCli";
            }
            Consultar();
        }

        string reporte = "";
        string Campo = "";
        String tabla = "";
        public override void Consultar()
        {
            String CMD = "Select * From " + tabla;

            if (!String.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                CMD += " where " + Campo + " Like('%" + textBox1.Text.Trim() + "%')";
            }

            DS = Utilidades.Utilidades.Ejecutar(CMD);

            if (DS.Tables.Count > 0)
                dataGridView1.DataSource = DS.Tables[0];
        }

        public override void Imprimir()
        {

            if (tabla.Equals("Ventas"))
            {
                ReporteProceso obj = new ReporteProceso();
                obj.reportViewer1.LocalReport.DataSources[0].Value = DS.Tables[0];
                obj.ShowDialog();

            }
            else if (tabla.Equals("Compras"))
            {
                ReporteProcesoCompra obj = new ReporteProcesoCompra();
                obj.reportViewer1.LocalReport.DataSources[0].Value = DS.Tables[0];
                obj.ShowDialog();
            }

        }


        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
                return;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
    }
