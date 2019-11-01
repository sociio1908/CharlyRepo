namespace Inventario
{
    partial class MantDepartamento
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.codigo = new ClassLibrary1.textBox(this.components);
            this.nombre = new ClassLibrary1.textBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 263);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 298);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 333);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 368);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(487, 0);
            this.panel1.Size = new System.Drawing.Size(119, 403);
            // 
            // Salir_btn
            // 
            this.Salir_btn.Location = new System.Drawing.Point(0, 221);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "CODIGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRE";
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(17, 101);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(70, 17);
            this.estado.TabIndex = 4;
            this.estado.Text = "ESTADO";
            this.estado.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(102, 29);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(130, 20);
            this.codigo.TabIndex = 5;
            this.codigo.Validar = false;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(100, 62);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(131, 20);
            this.nombre.TabIndex = 6;
            this.nombre.Validar = false;
            // 
            // MantDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 403);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MantDepartamento";
            this.Text = "RegistroDepartamento";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.estado, 0);
            this.Controls.SetChildIndex(this.codigo, 0);
            this.Controls.SetChildIndex(this.nombre, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox estado;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ClassLibrary1.textBox nombre;
        private ClassLibrary1.textBox codigo;
    }
}