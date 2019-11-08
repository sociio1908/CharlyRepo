namespace Inventario
{
    partial class FormCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompras));
            this.txt_disponibles = new System.Windows.Forms.Label();
            this.btn_ConsArt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.Label();
            this.btn_ConsSup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nomsup = new ClassLibrary1.textBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codsup = new ClassLibrary1.textBox(this.components);
            this.txt_Cant = new ClassLibrary1.textBox(this.components);
            this.txt_PreVen = new ClassLibrary1.textBox(this.components);
            this.txt_NomArt = new ClassLibrary1.textBox(this.components);
            this.txt_CodArt = new ClassLibrary1.textBox(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.Salir_btn.Location = new System.Drawing.Point(0, 522);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(930, 0);
            this.panel1.Size = new System.Drawing.Size(119, 564);
            // 
            // txt_disponibles
            // 
            this.txt_disponibles.AutoSize = true;
            this.txt_disponibles.Location = new System.Drawing.Point(571, 123);
            this.txt_disponibles.Name = "txt_disponibles";
            this.txt_disponibles.Size = new System.Drawing.Size(64, 13);
            this.txt_disponibles.TabIndex = 35;
            this.txt_disponibles.Text = "Disponibles:";
            // 
            // btn_ConsArt
            // 
            this.btn_ConsArt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ConsArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConsArt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ConsArt.Location = new System.Drawing.Point(17, 139);
            this.btn_ConsArt.Name = "btn_ConsArt";
            this.btn_ConsArt.Size = new System.Drawing.Size(38, 26);
            this.btn_ConsArt.TabIndex = 34;
            this.btn_ConsArt.Text = "[ F5 ]";
            this.btn_ConsArt.UseVisualStyleBackColor = true;
            this.btn_ConsArt.Click += new System.EventHandler(this.btn_ConsArt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "SUPLIDOR:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(689, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "TOTAL:";
            // 
            // txt_total
            // 
            this.txt_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(758, 522);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(166, 33);
            this.txt_total.TabIndex = 31;
            this.txt_total.Text = "0,00";
            this.txt_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(85, 7);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(144, 22);
            this.txt_usuario.TabIndex = 30;
            this.txt_usuario.Text = "nombre";
            this.txt_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ConsSup
            // 
            this.btn_ConsSup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ConsSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConsSup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ConsSup.Location = new System.Drawing.Point(163, 58);
            this.btn_ConsSup.Name = "btn_ConsSup";
            this.btn_ConsSup.Size = new System.Drawing.Size(66, 23);
            this.btn_ConsSup.TabIndex = 29;
            this.btn_ConsSup.Text = "Buscar";
            this.btn_ConsSup.UseVisualStyleBackColor = true;
            this.btn_ConsSup.Click += new System.EventHandler(this.btn_ConsSup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "USUARIO:";
            // 
            // txt_nomsup
            // 
            this.txt_nomsup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomsup.Location = new System.Drawing.Point(85, 89);
            this.txt_nomsup.Name = "txt_nomsup";
            this.txt_nomsup.ReadOnly = true;
            this.txt_nomsup.Size = new System.Drawing.Size(144, 22);
            this.txt_nomsup.TabIndex = 27;
            this.txt_nomsup.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "CODIGO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "NOMBRE:";
            // 
            // txt_codsup
            // 
            this.txt_codsup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codsup.Location = new System.Drawing.Point(85, 60);
            this.txt_codsup.Name = "txt_codsup";
            this.txt_codsup.Size = new System.Drawing.Size(66, 22);
            this.txt_codsup.TabIndex = 24;
            this.txt_codsup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_codsup.Validar = true;
            this.txt_codsup.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_codsup_KeyUp);
            // 
            // txt_Cant
            // 
            this.txt_Cant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cant.Location = new System.Drawing.Point(574, 139);
            this.txt_Cant.Name = "txt_Cant";
            this.txt_Cant.Size = new System.Drawing.Size(93, 26);
            this.txt_Cant.TabIndex = 23;
            this.txt_Cant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Cant.Validar = true;
            this.txt_Cant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Cant_KeyDown);
            this.txt_Cant.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Cant_KeyUp);
            // 
            // txt_PreVen
            // 
            this.txt_PreVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PreVen.Location = new System.Drawing.Point(414, 139);
            this.txt_PreVen.Name = "txt_PreVen";
            this.txt_PreVen.ReadOnly = true;
            this.txt_PreVen.Size = new System.Drawing.Size(154, 26);
            this.txt_PreVen.TabIndex = 22;
            this.txt_PreVen.Validar = true;
            // 
            // txt_NomArt
            // 
            this.txt_NomArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomArt.Location = new System.Drawing.Point(163, 139);
            this.txt_NomArt.Name = "txt_NomArt";
            this.txt_NomArt.ReadOnly = true;
            this.txt_NomArt.Size = new System.Drawing.Size(245, 26);
            this.txt_NomArt.TabIndex = 21;
            this.txt_NomArt.Validar = true;
            // 
            // txt_CodArt
            // 
            this.txt_CodArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodArt.Location = new System.Drawing.Point(61, 139);
            this.txt_CodArt.Name = "txt_CodArt";
            this.txt_CodArt.Size = new System.Drawing.Size(96, 26);
            this.txt_CodArt.TabIndex = 20;
            this.txt_CodArt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CodArt.Validar = true;
            this.txt_CodArt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_CodArt_KeyUp);
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
            this.dataGridView1.Location = new System.Drawing.Point(15, 171);
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
            this.dataGridView1.Size = new System.Drawing.Size(909, 348);
            this.dataGridView1.TabIndex = 19;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(286, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(456, 39);
            this.label5.TabIndex = 36;
            this.label5.Text = "COMPRA DE PRODUCTOS";
            // 
            // FormCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1049, 564);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_disponibles);
            this.Controls.Add(this.btn_ConsArt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_ConsSup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nomsup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_codsup);
            this.Controls.Add(this.txt_Cant);
            this.Controls.Add(this.txt_PreVen);
            this.Controls.Add(this.txt_NomArt);
            this.Controls.Add(this.txt_CodArt);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCompras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.FormCompras_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.txt_CodArt, 0);
            this.Controls.SetChildIndex(this.txt_NomArt, 0);
            this.Controls.SetChildIndex(this.txt_PreVen, 0);
            this.Controls.SetChildIndex(this.txt_Cant, 0);
            this.Controls.SetChildIndex(this.txt_codsup, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txt_nomsup, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btn_ConsSup, 0);
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

        private System.Windows.Forms.Label txt_disponibles;
        private System.Windows.Forms.Button btn_ConsArt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txt_total;
        private System.Windows.Forms.Label txt_usuario;
        private System.Windows.Forms.Button btn_ConsSup;
        private System.Windows.Forms.Label label3;
        private ClassLibrary1.textBox txt_nomsup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ClassLibrary1.textBox txt_codsup;
        private ClassLibrary1.textBox txt_Cant;
        private ClassLibrary1.textBox txt_PreVen;
        private ClassLibrary1.textBox txt_NomArt;
        private ClassLibrary1.textBox txt_CodArt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
    }
}