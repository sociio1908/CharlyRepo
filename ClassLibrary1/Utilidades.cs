using ClassLibrary1;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Utilidades
{
    public static class Utilidades
    {  
        public static void enviar_correo(string host, int puerto, string remitente, string contraseña, string nombre, string destinatarios, string cc, string asunto, string adjuntos, string cuerpo)
        {
            char[] delimitador_cc = { ',' };
            char[] delimitador_adjunto = { '|' };
            try
            {
                SmtpClient cliente = new SmtpClient(host, puerto);
                MailMessage correo = new MailMessage();

                correo.From = new MailAddress(remitente, nombre);
                correo.Body = cuerpo;
                correo.Subject = asunto;
                if (destinatarios == "") { }
                else
                {
                    string[] cadena = destinatarios.Split(delimitador_cc);
                    foreach (string word in cadena) correo.To.Add(word.Trim());
                }
                if (cc == "") { }
                else
                {
                    string[] cadena1 = cc.Split(delimitador_cc);
                    foreach (string word in cadena1) correo.CC.Add(word.Trim());
                }
                if (adjuntos == "") { }
                else
                {
                    string[] cadena2 = adjuntos.Split(delimitador_adjunto);
                    foreach (string word in cadena2) correo.Attachments.Add(new Attachment(word));
                }
                cliente.Credentials = new NetworkCredential(remitente, contraseña);
                cliente.EnableSsl = true;
                cliente.Send(correo);

                MessageBox.Show("El correo se ha enviado correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public static bool primo(int n)
        {

            for (int i = 2; i < n; i++) {
                if (n % 2 == 0) return false;
            }
            return true;
        }
        
        public static int Acceso = 1;
        public static String Usuario ="";
        public static String Impresora = "Microsoft XPS Document Witer";
        public static String email_user = "yeri.paulino@gmail.com";
        public static String email_pass = "yerimendoza1908";
        public static String email_destino = "";
        public static String des_email = "";
        public static String ruta_adjunto = @"C:\Users\Yeri Mendoza\Documents\Proyectos C#\Inventario\Inventario\bin\Release\";


        public static bool ValidarForm(Control Objform, ErrorProvider gp)
        {
            bool corredor = false;

             foreach (Control item in Objform.Controls)
                {
                if (item.Controls.Count > 0)
                {
                    bool corredor2 = ValidarForm(item, gp);
                    if (corredor2)
                       corredor = true;
                }
                if (item is textBox)
                {
                    textBox obj = (textBox)item;
                    if (obj.Validar)
                    {
                        if(string.IsNullOrEmpty(obj.Text.Trim()))
                        {
                            gp.SetError(obj, "Campo obligatorio.");
                            corredor = true;
                        }
                        else
                            gp.SetError(obj, "");
                    }
                }

             }
          //  MessageBox.Show("REgggggTONRO: "+corredor);
            return corredor;
        }


        public static void Prueba()
        {
            int[,] matriz = new int[5, 5];
            string almacen = "";
            int contp = 0, mayor1 = 0, menor1 = 0;

            //logica de matriz
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (c % 2 == 0)
                    {
                        matriz[f, c] = Convert.ToInt16(Math.Pow(f + c, 2));
                        //matriz[f, c] = f + c;
                    }
                    else
                    {
                        matriz[f, c] = f - c;
                    }
                }
            }

            //almacenar matriz en una variable
            for (int f = 0; f < 5; f++)
            {
                almacen += "\t";
                for (int c = 0; c < 5; c++)
                {
                    almacen += matriz[f, c] + "\t";
                }
                almacen += "\n";
            }
            //resultado matriz
            //   resultado.Text = almacen;


            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (primo(matriz[f, c]))
                    {
                        contp++;
                    }
                }
            }
            //primos
            //   primos.Text = contp.ToString();


            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (matriz[f, c] > mayor1)
                    {
                        mayor1 = matriz[f, c];
                    }
                }
            }
            //mayor
            //     mayor.Text = mayor1.ToString();

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (matriz[f, c] < menor1)
                    {
                        menor1 = matriz[f, c];
                    }
                }
            }

            //Menor
            //   menor.Text = menor1.ToString();
        }


        public static String conv999(int n)
        {
            if (n < 1 || n > 999) return "";
            if (n == 100) return "cien";
            String[] vu = new String[] { null, "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez", "once", "doce", "trece", "catorce", "quince", "dieciseis", "diecisiete", "dieciocho", "diecinueve", "veinte", "veintiuno", "veintidos", "veintitres", "veinticuatro", "veinticinco", "veintiseis", "veintisiete", "veintiocho", "veintinuevo", "treinta" };
            String[] vd = new String[] { null, "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
            String cn = n.ToString().PadLeft(3, '0');
            int c = Convert.ToInt16(cn.Substring(0, 1));
            int d = Convert.ToInt16(cn.Substring(1, 1));
            int u = Convert.ToInt16(cn.Substring(2, 1));
            int u2 = Convert.ToInt16(cn.Substring(1, 2));
            String letras = "";
            if (c > 0) letras = vu[c] + "cientos ";
            if (u2 > 0)
            {
                if (u2 < 30) letras += vu[u2];
                else
                {
                    letras += vd[d];
                    if (u > 0) letras += " y " + vu[u];
                }
            }
            //Arreglos
            letras = letras.Trim().ToLower();
            letras = letras.Replace("cincocientos", "quinientos");
            letras = letras.Replace("unocientos", "cien");
            letras = letras.Replace("sietecientos", "setecientos");
            letras = letras.Replace("nuevecientos", "novecientos");
            letras = letras.Replace("  ", " ");
            return letras;
        }

        public static String ConversionGrande(String numero)
        {
            String n = numero.Replace(',', ' ').Replace(" ", "");
            n = n.PadLeft(15, '0');
            int n1 = Convert.ToInt16(n.Substring(0, 3));
            int n2 = Convert.ToInt16(n.Substring(3, 3));
            int n3 = Convert.ToInt16(n.Substring(6, 3));
            int n4 = Convert.ToInt16(n.Substring(9, 3));
            int n5 = Convert.ToInt16(n.Substring(12, 3));

            String letra = "";
            if (n1 > 0) letra += conv999(n1) == "uno" ? "un billon" : conv999(n1) + " billones ";
            if (n2 > 0) letra += conv999(n2) == "uno" ? "mil millones " : conv999(n2) + " mil millones ";
            if (n3 > 0) letra += conv999(n3) == "uno" ? "un millon " : conv999(n3) + " millones ";
            if (n4 > 0) letra += conv999(n4) == "uno" ? "mil " : conv999(n4) + " mil ";
            if (n5 > 0) letra += conv999(n5);

            letra = letra.TrimStart();
            letra = letra.TrimEnd();
            letra = letra.Replace("  ", " ");
            return letra.ToUpper();

        }
     

     public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
            {
                return n * Factorial(n - 1);
            }
            
        }


        public static DataSet Ejecutar(String cmd)
        {
            SqlConnection Con = new SqlConnection(@"Data Source=.;Initial Catalog=BD_Inventario;Integrated Security=True");
            DataSet DS;
            Con.Open();

            SqlCommand com = new SqlCommand(cmd, Con);
            SqlDataAdapter DP = new SqlDataAdapter(com);
            DS = new DataSet();
            DP.Fill(DS);
            Con.Close();
            return DS;

        }

    }
}
