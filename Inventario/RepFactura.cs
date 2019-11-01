using Microsoft.Reporting.WinForms;
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
    public partial class RepFactura : Form
    {
        public RepFactura()
        {
            InitializeComponent();
        }

        private void RepFactura_Load(object sender, EventArgs e)
        {
       

            this.reportViewer1.RefreshReport();
        }
      
        private void btn_Enviar_Click(object sender, EventArgs e)
        {

            GuardarPDF();
            Utilidades.Utilidades.ruta_adjunto = Utilidades.Utilidades.ruta_adjunto + "archivo.pdf";
            EnviarCorreo obj = new EnviarCorreo();
            obj.ShowDialog();

        }

        void GuardarPDF()
        {
            Microsoft.Reporting.WinForms.Warning[] warnings;
            string[] streamids;
            string mimetype;
            string encoding;
            string filenameExtension;
            File.Delete("archivo.pdf");
            byte[] bytes = reportViewer1.LocalReport.Render(
              "PDF", null, out mimetype, out encoding, out filenameExtension, out streamids, out warnings);
            using (FileStream fs = new FileStream("archivo.pdf", FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
            if (File.Exists("archivo.pdf"))
            {
                MessageBox.Show("Se guardo correctamente.");
            }

        }

    }
}
