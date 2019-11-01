namespace Inventario
{
    partial class FormProceso
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
            this.Cancelar_btn = new System.Windows.Forms.Button();
            this.Imprimir_btn = new System.Windows.Forms.Button();
            this.Consultar_btn = new System.Windows.Forms.Button();
            this.Eliminar_btn = new System.Windows.Forms.Button();
            this.Salvar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Salir_btn
            // 
            this.Salir_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Salir_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Salir_btn.Location = new System.Drawing.Point(0, 408);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Salvar_btn);
            this.panel1.Controls.Add(this.Eliminar_btn);
            this.panel1.Controls.Add(this.Consultar_btn);
            this.panel1.Controls.Add(this.Imprimir_btn);
            this.panel1.Controls.Add(this.Cancelar_btn);
            this.panel1.Location = new System.Drawing.Point(681, 0);
            this.panel1.Size = new System.Drawing.Size(119, 450);
            this.panel1.Controls.SetChildIndex(this.Salir_btn, 0);
            this.panel1.Controls.SetChildIndex(this.Cancelar_btn, 0);
            this.panel1.Controls.SetChildIndex(this.Imprimir_btn, 0);
            this.panel1.Controls.SetChildIndex(this.Consultar_btn, 0);
            this.panel1.Controls.SetChildIndex(this.Eliminar_btn, 0);
            this.panel1.Controls.SetChildIndex(this.Salvar_btn, 0);
            // 
            // Cancelar_btn
            // 
            this.Cancelar_btn.BackColor = System.Drawing.Color.White;
            this.Cancelar_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Cancelar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Cancelar_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Cancelar_btn.Location = new System.Drawing.Point(0, 44);
            this.Cancelar_btn.Name = "Cancelar_btn";
            this.Cancelar_btn.Size = new System.Drawing.Size(119, 38);
            this.Cancelar_btn.TabIndex = 1;
            this.Cancelar_btn.Text = "Cancelar";
            this.Cancelar_btn.UseVisualStyleBackColor = false;
            this.Cancelar_btn.Click += new System.EventHandler(this.Cancelar_btn_Click);
            // 
            // Imprimir_btn
            // 
            this.Imprimir_btn.BackColor = System.Drawing.Color.White;
            this.Imprimir_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Imprimir_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Imprimir_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Imprimir_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Imprimir_btn.Location = new System.Drawing.Point(0, 127);
            this.Imprimir_btn.Name = "Imprimir_btn";
            this.Imprimir_btn.Size = new System.Drawing.Size(119, 38);
            this.Imprimir_btn.TabIndex = 1;
            this.Imprimir_btn.Text = "Imprimir";
            this.Imprimir_btn.UseVisualStyleBackColor = false;
            this.Imprimir_btn.Click += new System.EventHandler(this.Imprimir_btn_Click);
            // 
            // Consultar_btn
            // 
            this.Consultar_btn.BackColor = System.Drawing.Color.White;
            this.Consultar_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Consultar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consultar_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Consultar_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Consultar_btn.Location = new System.Drawing.Point(0, 3);
            this.Consultar_btn.Name = "Consultar_btn";
            this.Consultar_btn.Size = new System.Drawing.Size(119, 35);
            this.Consultar_btn.TabIndex = 2;
            this.Consultar_btn.Text = "Consultar";
            this.Consultar_btn.UseVisualStyleBackColor = false;
            this.Consultar_btn.Click += new System.EventHandler(this.Consultar_btn_Click);
            // 
            // Eliminar_btn
            // 
            this.Eliminar_btn.BackColor = System.Drawing.Color.White;
            this.Eliminar_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Eliminar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Eliminar_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Eliminar_btn.Location = new System.Drawing.Point(0, 88);
            this.Eliminar_btn.Name = "Eliminar_btn";
            this.Eliminar_btn.Size = new System.Drawing.Size(119, 33);
            this.Eliminar_btn.TabIndex = 3;
            this.Eliminar_btn.Text = "Eliminar";
            this.Eliminar_btn.UseVisualStyleBackColor = false;
            this.Eliminar_btn.Click += new System.EventHandler(this.Eliminar_btn_Click);
            // 
            // Salvar_btn
            // 
            this.Salvar_btn.BackColor = System.Drawing.Color.White;
            this.Salvar_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Salvar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salvar_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Salvar_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Salvar_btn.Location = new System.Drawing.Point(0, 171);
            this.Salvar_btn.Name = "Salvar_btn";
            this.Salvar_btn.Size = new System.Drawing.Size(119, 36);
            this.Salvar_btn.TabIndex = 4;
            this.Salvar_btn.Text = "Salvar";
            this.Salvar_btn.UseVisualStyleBackColor = false;
            this.Salvar_btn.Click += new System.EventHandler(this.Salvar_btn_Click);
            // 
            // FormProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormProceso";
            this.PuedeCancelar = true;
            this.PuedeConsultar = true;
            this.PuedeEliminar = true;
            this.PuedeImprimir = true;
            this.PuedeSalvar = true;
            this.Text = "FormProceso";
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancelar_btn;
        private System.Windows.Forms.Button Imprimir_btn;
        private System.Windows.Forms.Button Eliminar_btn;
        public System.Windows.Forms.Button Consultar_btn;
        private System.Windows.Forms.Button Salvar_btn;
    }
}