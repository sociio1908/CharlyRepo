namespace Inventario
{
    partial class MantArt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.codigo = new ClassLibrary1.textBox(this.components);
            this.nombre = new ClassLibrary1.textBox(this.components);
            this.PreVen = new ClassLibrary1.textBox(this.components);
            this.PreCom = new ClassLibrary1.textBox(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CanExi = new ClassLibrary1.textBox(this.components);
            this.CodDep = new ClassLibrary1.textBox(this.components);
            this.PunReo = new ClassLibrary1.textBox(this.components);
            this.CodSup = new ClassLibrary1.textBox(this.components);
            this.CodUni = new ClassLibrary1.textBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir_btn
            // 
            this.Salir_btn.Location = new System.Drawing.Point(0, 321);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(504, 0);
            this.panel1.Size = new System.Drawing.Size(119, 363);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "MANTENIMIENTO ARTICULOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "CODIGO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "PRE-VENTA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(13, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "PRE-COMPRA:";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(207, 54);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(83, 20);
            this.codigo.TabIndex = 14;
            this.codigo.Validar = false;
            this.codigo.Validating += new System.ComponentModel.CancelEventHandler(this.codigo_Validating);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(207, 81);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(148, 20);
            this.nombre.TabIndex = 15;
            this.nombre.Validar = false;
            // 
            // PreVen
            // 
            this.PreVen.Location = new System.Drawing.Point(208, 108);
            this.PreVen.Name = "PreVen";
            this.PreVen.Size = new System.Drawing.Size(109, 20);
            this.PreVen.TabIndex = 16;
            this.PreVen.Validar = false;
            // 
            // PreCom
            // 
            this.PreCom.Location = new System.Drawing.Point(209, 135);
            this.PreCom.Name = "PreCom";
            this.PreCom.Size = new System.Drawing.Size(109, 20);
            this.PreCom.TabIndex = 17;
            this.PreCom.Validar = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(14, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "COD. SUPLIDOR:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(14, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "COD. DEPARTAMENTO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(13, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "CANTIDAD EXISTENTE:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(14, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "PUNTO REORDEN";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(14, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "COD. UNIDAD:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // CanExi
            // 
            this.CanExi.Location = new System.Drawing.Point(210, 162);
            this.CanExi.Name = "CanExi";
            this.CanExi.Size = new System.Drawing.Size(81, 20);
            this.CanExi.TabIndex = 23;
            this.CanExi.Validar = false;
            // 
            // CodDep
            // 
            this.CodDep.Location = new System.Drawing.Point(209, 190);
            this.CodDep.Name = "CodDep";
            this.CodDep.Size = new System.Drawing.Size(78, 20);
            this.CodDep.TabIndex = 24;
            this.CodDep.Validar = false;
            // 
            // PunReo
            // 
            this.PunReo.Location = new System.Drawing.Point(209, 270);
            this.PunReo.Name = "PunReo";
            this.PunReo.Size = new System.Drawing.Size(78, 20);
            this.PunReo.TabIndex = 25;
            this.PunReo.Validar = false;
            // 
            // CodSup
            // 
            this.CodSup.Location = new System.Drawing.Point(209, 216);
            this.CodSup.Name = "CodSup";
            this.CodSup.Size = new System.Drawing.Size(78, 20);
            this.CodSup.TabIndex = 25;
            this.CodSup.Validar = false;
            // 
            // CodUni
            // 
            this.CodUni.Location = new System.Drawing.Point(209, 243);
            this.CodUni.Name = "CodUni";
            this.CodUni.Size = new System.Drawing.Size(78, 20);
            this.CodUni.TabIndex = 26;
            this.CodUni.Validar = false;
            // 
            // MantArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 363);
            this.Controls.Add(this.CodUni);
            this.Controls.Add(this.CodSup);
            this.Controls.Add(this.PunReo);
            this.Controls.Add(this.CodDep);
            this.Controls.Add(this.CanExi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PreCom);
            this.Controls.Add(this.PreVen);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantArt";
            this.Text = "ARTICULOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.codigo, 0);
            this.Controls.SetChildIndex(this.nombre, 0);
            this.Controls.SetChildIndex(this.PreVen, 0);
            this.Controls.SetChildIndex(this.PreCom, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.CanExi, 0);
            this.Controls.SetChildIndex(this.CodDep, 0);
            this.Controls.SetChildIndex(this.PunReo, 0);
            this.Controls.SetChildIndex(this.CodSup, 0);
            this.Controls.SetChildIndex(this.CodUni, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private ClassLibrary1.textBox codigo;
        private ClassLibrary1.textBox nombre;
        private ClassLibrary1.textBox PreVen;
        private ClassLibrary1.textBox PreCom;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private ClassLibrary1.textBox CanExi;
        private ClassLibrary1.textBox CodUni;
        private ClassLibrary1.textBox CodSup;
        private ClassLibrary1.textBox PunReo;
        private ClassLibrary1.textBox CodDep;
    }
}