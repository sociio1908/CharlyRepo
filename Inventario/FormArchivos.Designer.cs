namespace Inventario
{
    partial class FormArchivos
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
            this.txt_contenido = new System.Windows.Forms.RichTextBox();
            this.txt_nombre = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_crear = new System.Windows.Forms.Button();
            this.btn_leer = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_limpiarCampos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_contenido
            // 
            this.txt_contenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contenido.Location = new System.Drawing.Point(12, 129);
            this.txt_contenido.Name = "txt_contenido";
            this.txt_contenido.Size = new System.Drawing.Size(420, 130);
            this.txt_contenido.TabIndex = 0;
            this.txt_contenido.Text = "";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(12, 51);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(183, 33);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOMBRE DEL ARCHIVO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(11, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTENIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(477, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "ACCIONES";
            // 
            // btn_crear
            // 
            this.btn_crear.BackColor = System.Drawing.Color.Teal;
            this.btn_crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_crear.Location = new System.Drawing.Point(449, 78);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(126, 40);
            this.btn_crear.TabIndex = 5;
            this.btn_crear.Text = "CREAR";
            this.btn_crear.UseVisualStyleBackColor = false;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // btn_leer
            // 
            this.btn_leer.BackColor = System.Drawing.Color.Teal;
            this.btn_leer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_leer.Location = new System.Drawing.Point(449, 124);
            this.btn_leer.Name = "btn_leer";
            this.btn_leer.Size = new System.Drawing.Size(126, 40);
            this.btn_leer.TabIndex = 6;
            this.btn_leer.Text = "LEER";
            this.btn_leer.UseVisualStyleBackColor = false;
            this.btn_leer.Click += new System.EventHandler(this.btn_leer_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Teal;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_eliminar.Location = new System.Drawing.Point(449, 170);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(126, 40);
            this.btn_eliminar.TabIndex = 7;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Teal;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(219, 277);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(180, 58);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "CERRAR";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_limpiarCampos
            // 
            this.btn_limpiarCampos.BackColor = System.Drawing.Color.Teal;
            this.btn_limpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiarCampos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_limpiarCampos.Location = new System.Drawing.Point(449, 216);
            this.btn_limpiarCampos.Name = "btn_limpiarCampos";
            this.btn_limpiarCampos.Size = new System.Drawing.Size(126, 40);
            this.btn_limpiarCampos.TabIndex = 9;
            this.btn_limpiarCampos.Text = "LIMPIAR CAMPOS";
            this.btn_limpiarCampos.UseVisualStyleBackColor = false;
            this.btn_limpiarCampos.Click += new System.EventHandler(this.btn_limpiarCampos_Click);
            // 
            // FormArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 347);
            this.Controls.Add(this.btn_limpiarCampos);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_leer);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_contenido);
            this.MaximumSize = new System.Drawing.Size(603, 386);
            this.MinimumSize = new System.Drawing.Size(603, 386);
            this.Name = "FormArchivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormArchivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_contenido;
        private System.Windows.Forms.RichTextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Button btn_leer;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_limpiarCampos;
    }
}