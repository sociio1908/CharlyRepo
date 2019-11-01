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
    public partial class ConsultaDepartamento : FormConsultas
    {
        public ConsultaDepartamento()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            Consultar(); 
        }

        public override void Consultar()
        {
            String CMD = "Select * From Departamento";
            if (String.IsNullOrEmpty(textBox1.Text.Trim())){
                CMD += " where NomDep  Like('%" + textBox1.Text.Trim() + "%')";
                DS = Utilidades.Utilidades.Ejecutar(CMD);

                if (DS.Tables.Count > 0)
                    dataGridView1.DataSource = DS.Tables[0];


            }


        }



    }
}
