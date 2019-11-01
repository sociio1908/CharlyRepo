namespace Inventario
{
    partial class EnviarCorreo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.correo_remitente = new ClassLibrary1.textBox(this.components);
            this.txt_abjuntos = new ClassLibrary1.textBox(this.components);
            this.txt_destinatarios = new ClassLibrary1.textBox(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_mensaje = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contrasena_remitente = new ClassLibrary1.textBox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btn_abjuntar = new System.Windows.Forms.Button();
            this.c_ver = new System.Windows.Forms.CheckBox();
            this.txt_asunto = new ClassLibrary1.textBox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cc = new ClassLibrary1.textBox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir_btn
            // 
            this.Salir_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Salir_btn.Location = new System.Drawing.Point(0, 421);
            this.Salir_btn.Size = new System.Drawing.Size(124, 42);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(860, 0);
            this.panel1.Size = new System.Drawing.Size(124, 463);
            // 
            // btn_enviar
            // 
            this.btn_enviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_enviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_enviar.Location = new System.Drawing.Point(727, 271);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(127, 51);
            this.btn_enviar.TabIndex = 1;
            this.btn_enviar.Text = "ENVIAR";
            this.btn_enviar.UseVisualStyleBackColor = true;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_limpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_limpiar.Location = new System.Drawing.Point(727, 403);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(127, 51);
            this.btn_limpiar.TabIndex = 2;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // correo_remitente
            // 
            this.correo_remitente.Location = new System.Drawing.Point(12, 36);
            this.correo_remitente.Name = "correo_remitente";
            this.correo_remitente.Size = new System.Drawing.Size(213, 20);
            this.correo_remitente.TabIndex = 3;
            this.correo_remitente.Validar = false;
            // 
            // txt_abjuntos
            // 
            this.txt_abjuntos.Location = new System.Drawing.Point(12, 186);
            this.txt_abjuntos.Name = "txt_abjuntos";
            this.txt_abjuntos.ReadOnly = true;
            this.txt_abjuntos.Size = new System.Drawing.Size(709, 20);
            this.txt_abjuntos.TabIndex = 5;
            this.txt_abjuntos.Validar = false;
            // 
            // txt_destinatarios
            // 
            this.txt_destinatarios.Location = new System.Drawing.Point(12, 87);
            this.txt_destinatarios.Name = "txt_destinatarios";
            this.txt_destinatarios.Size = new System.Drawing.Size(709, 20);
            this.txt_destinatarios.TabIndex = 6;
            this.txt_destinatarios.Validar = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txt_mensaje
            // 
            this.txt_mensaje.Location = new System.Drawing.Point(12, 231);
            this.txt_mensaje.Name = "txt_mensaje";
            this.txt_mensaje.Size = new System.Drawing.Size(709, 232);
            this.txt_mensaje.TabIndex = 7;
            this.txt_mensaje.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(15, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "MENSAJE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "DESTINATARIOS (Separados por \' , \' )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "ABJUNTAR ARCHIVOS: (Auto separado por \' | \' )";
            // 
            // contrasena_remitente
            // 
            this.contrasena_remitente.Location = new System.Drawing.Point(231, 36);
            this.contrasena_remitente.Name = "contrasena_remitente";
            this.contrasena_remitente.Size = new System.Drawing.Size(213, 20);
            this.contrasena_remitente.TabIndex = 12;
            this.contrasena_remitente.UseSystemPasswordChar = true;
            this.contrasena_remitente.Validar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(237, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Contraseña:";
            // 
            // btn_abjuntar
            // 
            this.btn_abjuntar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_abjuntar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_abjuntar.Location = new System.Drawing.Point(727, 183);
            this.btn_abjuntar.Name = "btn_abjuntar";
            this.btn_abjuntar.Size = new System.Drawing.Size(127, 23);
            this.btn_abjuntar.TabIndex = 14;
            this.btn_abjuntar.Text = "Abrir archivos";
            this.btn_abjuntar.UseVisualStyleBackColor = true;
            this.btn_abjuntar.Click += new System.EventHandler(this.btn_abjuntar_Click);
            // 
            // c_ver
            // 
            this.c_ver.AutoSize = true;
            this.c_ver.Location = new System.Drawing.Point(451, 38);
            this.c_ver.Name = "c_ver";
            this.c_ver.Size = new System.Drawing.Size(42, 17);
            this.c_ver.TabIndex = 15;
            this.c_ver.Text = "Ver";
            this.c_ver.UseVisualStyleBackColor = true;
            this.c_ver.CheckedChanged += new System.EventHandler(this.c_ver_CheckedChanged);
            // 
            // txt_asunto
            // 
            this.txt_asunto.Location = new System.Drawing.Point(12, 138);
            this.txt_asunto.Name = "txt_asunto";
            this.txt_asunto.Size = new System.Drawing.Size(213, 20);
            this.txt_asunto.TabIndex = 16;
            this.txt_asunto.Validar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(15, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "ASUNTO:";
            // 
            // txt_cc
            // 
            this.txt_cc.Location = new System.Drawing.Point(231, 138);
            this.txt_cc.Name = "txt_cc";
            this.txt_cc.Size = new System.Drawing.Size(231, 20);
            this.txt_cc.TabIndex = 18;
            this.txt_cc.Validar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(231, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "CC:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancelar.Location = new System.Drawing.Point(727, 337);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(127, 51);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // EnviarCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 463);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_cc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_asunto);
            this.Controls.Add(this.c_ver);
            this.Controls.Add(this.btn_abjuntar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contrasena_remitente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mensaje);
            this.Controls.Add(this.txt_destinatarios);
            this.Controls.Add(this.txt_abjuntos);
            this.Controls.Add(this.correo_remitente);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_enviar);
            this.Name = "EnviarCorreo";
            this.Text = "EnviarCorreo";
            this.Controls.SetChildIndex(this.btn_enviar, 0);
            this.Controls.SetChildIndex(this.btn_limpiar, 0);
            this.Controls.SetChildIndex(this.correo_remitente, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.txt_abjuntos, 0);
            this.Controls.SetChildIndex(this.txt_destinatarios, 0);
            this.Controls.SetChildIndex(this.txt_mensaje, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.contrasena_remitente, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btn_abjuntar, 0);
            this.Controls.SetChildIndex(this.c_ver, 0);
            this.Controls.SetChildIndex(this.txt_asunto, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txt_cc, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btn_cancelar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Button btn_limpiar;
        private ClassLibrary1.textBox correo_remitente;
        private ClassLibrary1.textBox txt_destinatarios;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RichTextBox txt_mensaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ClassLibrary1.textBox contrasena_remitente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_abjuntar;
        private System.Windows.Forms.CheckBox c_ver;
        private ClassLibrary1.textBox txt_asunto;
        private System.Windows.Forms.Label label6;
        private ClassLibrary1.textBox txt_cc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_cancelar;
        public ClassLibrary1.textBox txt_abjuntos;
    }
}