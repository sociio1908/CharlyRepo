using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inventario
{
    class ConexionBD
    {
        String cadena = "Data Source=DESKTOP-GMKQRUI; Initial Catalog = ventas1; Integrated Security = true";
        public SqlConnection conector = new SqlConnection();

        public ConexionBD()
        {
            conector.ConnectionString = cadena;
            
        }
        public void Abrir()
        {
            try
            {
                conector.Open();
                MessageBox.Show("Conexion a SQL correcta.");

            }
            catch (Exception e)
            {
                MessageBox.Show("Conexion a SQL incorrecta. ERROR: "+e);

            }
        }

        public void Cerrar()
        {
            conector.Close();
        }

    }
}
