using System;

using System.Media;
using System.Windows.Forms;
namespace Inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.numero.Focus();
            this.voz_btn.Enabled = false;
            
        }



        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("*HASTA LA VISTA CAMPEON*","Adios",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Close();
          
        }

        private void numero_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!Char.IsNumber(e.KeyChar) && Convert.ToInt16(e.KeyChar) != 8)
            {
                e.Handled = true;
                MessageBox.Show(" SOLO NUMEROS PERMITIDOS.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            if (numero.Text.Length>15)
            {
                e.Handled = true;
                MessageBox.Show("NO PUEDE CONTENER MAS DE 15 DIGITOS.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultado.Clear();
            if (numero.Text.Equals("") == false)
            {

                resultado.AppendText(Utilidades.Utilidades.ConversionGrande(numero.Text));
                if (resultado.Text.Equals("") == false)
                    voz_btn.Enabled = true;
                

            }
            else
            {
                MessageBox.Show("INGRESE UN VALOR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        SoundPlayer sonido;
        private void salir_btn_Click(object sender, EventArgs e)
        {

            if (resultado.Text.Equals("")==false )
            {
              
                try
                {
                    int cont = 1;
                    String numero_letras = resultado.Text.ToLower().ToString();
                    String nombre = "";
                    numero_letras = numero_letras.Replace("ochocientos","ocho cientos");
                    numero_letras = numero_letras.Replace("doscientos", "dos cientos");
                    numero_letras = numero_letras.Replace("trescientos", "tres cientos");
                    numero_letras = numero_letras.Replace("cuatrocientos", "cuatro cientos");
                    numero_letras = numero_letras.Replace("seiscientos", "seis cientos");
                    numero_letras = numero_letras.Replace("  ", " ");
                    //MessageBox.Show("LETRAS: " + numero_letras);

                    //Contador de palabras
                    char[] Vector = new char[numero_letras.Length];
                    Vector = numero_letras.ToCharArray();
                    for (int a =0;a< Vector.Length;a++)
                    {
                        if (Vector[a].ToString().Equals(" "))
                        {
                            cont++;

                        }
                       
                    }
                    //Reproduccion de audio
                    for (int a = 0; a < cont; a++)
                    {
                        nombre = numero_letras.Split(' ')[a] + ".wav";
                        sonido = new SoundPlayer(@"C:\Users\Yeri Mendoza\Documents\Proyectos C#\Inventario\Inventario\bin\Debug\Numeros\" + nombre);
                        sonido.PlaySync();
                        
                    }


                }
                catch (Exception E) {
                 //   MessageBox.Show("NO SE ENCONTRO ESE ARCHIVO: " + E);

                }

            }     
            else
            {
                MessageBox.Show("INGRESE UN NUMERO. ", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }
    }
}
