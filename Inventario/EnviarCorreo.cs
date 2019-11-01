using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Inventario
{
    public partial class EnviarCorreo : FormBase
    {
        public EnviarCorreo()
        {
            InitializeComponent();
            correo_remitente.Text = Utilidades.Utilidades.email_user;
            contrasena_remitente.Text = Utilidades.Utilidades.email_pass;
            txt_destinatarios.Text = Utilidades.Utilidades.email_destino;
            txt_mensaje.Text = Utilidades.Utilidades.des_email;
            txt_asunto.Text = Utilidades.Utilidades.des_email;
            txt_abjuntos.Text = Utilidades.Utilidades.ruta_adjunto;

        }


        char[] delimitador_cc = { ',' };
        char[] delimitador_adjunto = { '|' };
        

        private void c_ver_CheckedChanged(object sender, EventArgs e)
        {
            
            if (c_ver.Checked==true) {
                contrasena_remitente.UseSystemPasswordChar = false;

            }
            else
            {
                contrasena_remitente.UseSystemPasswordChar = true;

            }

        }

        private void btn_abjuntar_Click(object sender, EventArgs e)
        {
            AbjuntarArchivos();
        }


        public void AbjuntarArchivos()
        {
            OpenFileDialog menu_abrir = new OpenFileDialog();
            menu_abrir.Filter = "Todos los archivos|*.*";
            menu_abrir.Title = "Abjuntar archivos";
            menu_abrir.InitialDirectory = @"C:\";
            if (menu_abrir.ShowDialog() == DialogResult.OK)
            {
                if (txt_abjuntos.Text == "" || txt_abjuntos.Text == null) txt_abjuntos.Text = menu_abrir.FileName;
                else txt_abjuntos.Text += @"|" + menu_abrir.FileName;
            }
        }
        
        private void btn_enviar_Click(object sender, EventArgs e)
        {
            /*CONFIGURACIÓN SMTP:
         ---------------------------------------------------------
         * OUTLOOK -->
           servidor SMTP: smtp-mail.outlook.com
           puerto: 587   
         ---------------------------------------------------------
         * GMAIL -->         
           servidor SMTP: smtp.gmail.com
         * puerto: 465 (SSL); 587 (TLS)
         ---------------------------------------------------------
         * YAHOO! -->
           servidor SMTP: smtp.mail.yahoo.com
           puerto: 25 ó 265
        */
            String host = "smtp.gmail.com";
            int puerto = 587;
            if (correo_remitente.Text.Trim().Equals("")==false && contrasena_remitente.Text.Trim().Equals("") == false && txt_destinatarios.Text.Trim().Equals("") == false && txt_asunto.Text.Trim().Equals("") == false && txt_mensaje.Text.Trim().Equals("") == false)
            {
                if (correo_remitente.Text.Contains("yahoo.com") || (correo_remitente.Text.Contains("yahoo.es")))
                {
                     host = "smtp.mail.yahoo.com";
                     puerto = 265;
                }
                if (correo_remitente.Text.Contains("outlook.com") || (correo_remitente.Text.Contains("outlook.es") || (correo_remitente.Text.Contains("hotmail.com"))))
                {
                    host = "smtp-mail.outlook.com";
                  
                }
                Utilidades.Utilidades.enviar_correo(host, puerto, correo_remitente.Text, contrasena_remitente.Text,"", txt_destinatarios.Text, txt_cc.Text, txt_asunto.Text, txt_abjuntos.Text, txt_mensaje.Text);
                LimpiarCampos();
            }

            else
            {
                MessageBox.Show("Complete todos los campos correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        void LimpiarCampos()
        {
            txt_mensaje.Clear();
            txt_destinatarios.Clear();
            txt_cc.Clear();
            txt_asunto.Clear();
            txt_abjuntos.Clear();
            //correo_remitente.Clear();
            //contrasena_remitente.Clear();
            c_ver.Checked = false;
        }


    }
}
