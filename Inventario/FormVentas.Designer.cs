namespace Inventario
{
    partial class FormVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_CodArt = new ClassLibrary1.textBox(this.components);
            this.txt_NomArt = new ClassLibrary1.textBox(this.components);
            this.txt_PreVen = new ClassLibrary1.textBox(this.components);
            this.txt_Cant = new ClassLibrary1.textBox(this.components);
            this.txt_codcli = new ClassLibrary1.textBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nomcli = new ClassLibrary1.textBox(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ConsCli = new System.Windows.Forms.Button();
            this.txt_usuario = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ConsArt = new System.Windows.Forms.Button();
            this.txt_disponibles = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Consultar_btn
            // 
            this.Consultar_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // Salir_btn
            // 
            this.Salir_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Salir_btn.Location = new System.Drawing.Point(0, 497);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(887, 0);
            this.panel1.Size = new System.Drawing.Size(119, 539);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodArt,
            this.DesArt,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.GridColor = System.Drawing.Color.Chocolate;
            this.dataGridView1.Location = new System.Drawing.Point(12, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(869, 314);
            this.dataGridView1.TabIndex = 1;
            // 
            // CodArt
            // 
            this.CodArt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodArt.DefaultCellStyle = dataGridViewCellStyle2;
            this.CodArt.FillWeight = 15.61856F;
            this.CodArt.HeaderText = "Codigo";
            this.CodArt.Name = "CodArt";
            this.CodArt.ReadOnly = true;
            // 
            // DesArt
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DesArt.DefaultCellStyle = dataGridViewCellStyle3;
            this.DesArt.FillWeight = 25.61856F;
            this.DesArt.HeaderText = "Descripcion";
            this.DesArt.Name = "DesArt";
            this.DesArt.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.FillWeight = 15.61856F;
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.FillWeight = 10.61856F;
            this.Column4.HeaderText = "Cantidad";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.FillWeight = 20.61856F;
            this.Column5.HeaderText = "Importe";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // txt_CodArt
            // 
            this.txt_CodArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodArt.Location = new System.Drawing.Point(58, 141);
            this.txt_CodArt.Name = "txt_CodArt";
            this.txt_CodArt.Size = new System.Drawing.Size(96, 26);
            this.txt_CodArt.TabIndex = 2;
            this.txt_CodArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CodArt.Validar = true;
            this.txt_CodArt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_CodArt_KeyUp);
            // 
            // txt_NomArt
            // 
            this.txt_NomArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomArt.Location = new System.Drawing.Point(160, 141);
            this.txt_NomArt.Name = "txt_NomArt";
            this.txt_NomArt.ReadOnly = true;
            this.txt_NomArt.Size = new System.Drawing.Size(245, 26);
            this.txt_NomArt.TabIndex = 3;
            this.txt_NomArt.Validar = true;
            // 
            // txt_PreVen
            // 
            this.txt_PreVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PreVen.Location = new System.Drawing.Point(411, 141);
            this.txt_PreVen.Name = "txt_PreVen";
            this.txt_PreVen.ReadOnly = true;
            this.txt_PreVen.Size = new System.Drawing.Size(154, 26);
            this.txt_PreVen.TabIndex = 4;
            this.txt_PreVen.Validar = true;
            // 
            // txt_Cant
            // 
            this.txt_Cant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cant.Location = new System.Drawing.Point(571, 141);
            this.txt_Cant.Name = "txt_Cant";
            this.txt_Cant.Size = new System.Drawing.Size(93, 26);
            this.txt_Cant.TabIndex = 5;
            this.txt_Cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Cant.Validar = true;
            this.txt_Cant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Cant_KeyDown);
            this.txt_Cant.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Cant_KeyUp);
            // 
            // txt_codcli
            // 
            this.txt_codcli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codcli.Location = new System.Drawing.Point(82, 62);
            this.txt_codcli.Name = "txt_codcli";
            this.txt_codcli.Size = new System.Drawing.Size(66, 22);
            this.txt_codcli.TabIndex = 6;
            this.txt_codcli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_codcli.Validar = true;
            this.txt_codcli.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_codcli_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CODIGO:";
            // 
            // txt_nomcli
            // 
            this.txt_nomcli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomcli.Location = new System.Drawing.Point(82, 91);
            this.txt_nomcli.Name = "txt_nomcli";
            this.txt_nomcli.ReadOnly = true;
            this.txt_nomcli.Size = new System.Drawing.Size(144, 22);
            this.txt_nomcli.TabIndex = 9;
            this.txt_nomcli.Validar = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "USUARIO:";
            // 
            // btn_ConsCli
            // 
            this.btn_ConsCli.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ConsCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConsCli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ConsCli.Location = new System.Drawing.Point(160, 60);
            this.btn_ConsCli.Name = "btn_ConsCli";
            this.btn_ConsCli.Size = new System.Drawing.Size(66, 23);
            this.btn_ConsCli.TabIndex = 12;
            this.btn_ConsCli.Text = "Buscar";
            this.btn_ConsCli.UseVisualStyleBackColor = true;
            this.btn_ConsCli.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(82, 9);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(144, 22);
            this.txt_usuario.TabIndex = 13;
            this.txt_usuario.Text = "nombre";
            this.txt_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_total
            // 
            this.txt_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(715, 497);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(166, 33);
            this.txt_total.TabIndex = 14;
            this.txt_total.Text = "0,00";
            this.txt_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(646, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "TOTAL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "CLIENTE:";
            // 
            // btn_ConsArt
            // 
            this.btn_ConsArt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ConsArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConsArt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ConsArt.Location = new System.Drawing.Point(14, 141);
            this.btn_ConsArt.Name = "btn_ConsArt";
            this.btn_ConsArt.Size = new System.Drawing.Size(38, 26);
            this.btn_ConsArt.TabIndex = 17;
            this.btn_ConsArt.Text = "[ + ]";
            this.btn_ConsArt.UseVisualStyleBackColor = true;
            this.btn_ConsArt.Click += new System.EventHandler(this.btn_ConsArt_Click);
            // 
            // txt_disponibles
            // 
            this.txt_disponibles.AutoSize = true;
            this.txt_disponibles.Location = new System.Drawing.Point(568, 125);
            this.txt_disponibles.Name = "txt_disponibles";
            this.txt_disponibles.Size = new System.Drawing.Size(64, 13);
            this.txt_disponibles.TabIndex = 18;
            this.txt_disponibles.Text = "Disponibles:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(290, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(419, 39);
            this.label5.TabIndex = 37;
            this.label5.Text = "VENTA DE PRODUCTOS";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1006, 539);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_disponibles);
            this.Controls.Add(this.btn_ConsArt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_ConsCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nomcli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_codcli);
            this.Controls.Add(this.txt_Cant);
            this.Controls.Add(this.txt_PreVen);
            this.Controls.Add(this.txt_NomArt);
            this.Controls.Add(this.txt_CodArt);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1022, 578);
            this.Name = "FormVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.txt_CodArt, 0);
            this.Controls.SetChildIndex(this.txt_NomArt, 0);
            this.Controls.SetChildIndex(this.txt_PreVen, 0);
            this.Controls.SetChildIndex(this.txt_Cant, 0);
            this.Controls.SetChildIndex(this.txt_codcli, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_nomcli, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btn_ConsCli, 0);
            this.Controls.SetChildIndex(this.txt_usuario, 0);
            this.Controls.SetChildIndex(this.txt_total, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.btn_ConsArt, 0);
            this.Controls.SetChildIndex(this.txt_disponibles, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ClassLibrary1.textBox txt_CodArt;
        private ClassLibrary1.textBox txt_NomArt;
        private ClassLibrary1.textBox txt_PreVen;
        private ClassLibrary1.textBox txt_Cant;
        private ClassLibrary1.textBox txt_codcli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ClassLibrary1.textBox txt_nomcli;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ConsCli;
        private System.Windows.Forms.Label txt_usuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txt_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ConsArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label txt_disponibles;
        private System.Windows.Forms.Label label5;
    }
}