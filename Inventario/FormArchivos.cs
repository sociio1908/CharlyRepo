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
    public partial class FormArchivos : Form
    {
        public FormArchivos()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text.Equals("")==false && txt_contenido.Text.Equals("") == false)
            {

                GuardarTxt(txt_nombre.Text, txt_contenido.Text);
                LimpiarCampos();
                MessageBox.Show("ARCHIVO CREADO EXITOSAMENTE.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("FAVOR INGRESAR EL NOMBRE Y EL CONTENIDO DEL ARCHIVO.","ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_nombre.Focus();
            }




        }

        private void btn_leer_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text.Equals("") == false)
            {
               List<String>  res = LeerTxt(txt_nombre.Text);
                if (res.Count()>0)
                {
                    txt_contenido.Clear();
                    txt_contenido.Lines = res.ToArray();
                    
                }
                else
                {
                    MessageBox.Show("ARCHIVO NO EXISTENTE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_nombre.Focus();
                }

            }
            else
            {
                MessageBox.Show("FAVOR INGRESAR EL NOMBRE DEL ARCHIVO.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
            }


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text.Equals("") == false)
            {
                if (BorrarTxt(txt_nombre.Text)==true)
                {
                    LimpiarCampos();
                    MessageBox.Show("ARCHIVO ELIMINADO CON EXITO.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                }
                

            }
            else
            {
                MessageBox.Show("FAVOR INGRESAR EL NOMBRE DEL ARCHIVO.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
            }


        }
   
        public void GuardarTxt(String nombre, String contenido)
        {

            try
            {

                StreamWriter escritor = new StreamWriter(nombre.ToLower() + ".txt");
                escritor.Write(contenido + "\n");
                escritor.Close();

            }
            catch (IOException e)
            {
                MessageBox.Show("ERROR AL ESCRIBIR: "+e);
            }
        
        }


        public List<String> LeerTxt(String nombre)
        {
            List<String> contenido = new List<String>();
            try
            {
               
                if (File.Exists(nombre.ToLower() + ".txt")) {
                    contenido.Clear();
                    StreamReader lector = new StreamReader(nombre.ToLower() + ".txt");
                    String linea = "";
                    while(linea != null){
                        linea = lector.ReadLine();
                      
                        if (linea != null)
                            contenido.Add(linea);
                       
                    }
                    lector.Close();
                    return contenido;
                }
                else
                {
                    return contenido;
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("ERROR AL LEER: " + e);
            }

            return contenido;
        }

        public bool BorrarTxt(String nombre)
        {

            try
            {
                if (File.Exists(nombre.ToLower() + ".txt"))
                {
                    int  opc = (int) MessageBox.Show("SEGURO QUE DESEA ELIMINAR EL ARCHIVO: *" + nombre + "* ?", "AVISO", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                    if (opc==1)
                    {
                        File.Delete(nombre.ToLower() + ".txt");
                        return true;

                    }

                }
                else
                {
                    MessageBox.Show("ARCHIVO NO EXISTE.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (IOException e)
            {
                MessageBox.Show("ERROR AL BORRAR EL ARCHIVO: " + e);
            }
            return false;
        }

        private void btn_limpiarCampos_Click(object sender, EventArgs e)
        {
            
            LimpiarCampos();
            

        }

        void LimpiarCampos()
        {
            txt_nombre.Clear();
            txt_contenido.Clear();
            txt_nombre.Focus();

        }
    }
}
