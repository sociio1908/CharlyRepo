using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inventario
{
    public partial class FormBase : Form
    {
        public  bool PuedeSalvar { set; get; }
        public bool PuedeEliminar { set; get; }

        public bool PuedeImprimir { set; get; }

        public bool PuedeCancelar { set; get; }

        public bool PuedeConsultar { set; get; }

        public FormBase()
        {
            InitializeComponent();

        }

        private void Salir_btn_Click(object sender, EventArgs e)
        {
            Close();
         }

        

         public virtual void Salvar() { }

         public virtual void Eliminar() { }

         public virtual void Imprimir() { }

         public virtual void Cancelar() { }

         public virtual void Consultar() { }

        public DataSet DS = new DataSet();

       
    }
}
