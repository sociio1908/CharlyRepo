namespace Inventario
{
    partial class ConsArt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new ClassLibrary1.textBox(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColColPreVen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPreCom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodSup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCodUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCanExi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GruArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPunReo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Salir_btn
            // 
            this.Salir_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Salir_btn.Location = new System.Drawing.Point(0, 445);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(866, 0);
            this.panel1.Size = new System.Drawing.Size(119, 487);
            this.panel1.Controls.SetChildIndex(this.Salir_btn, 0);
            this.panel1.Controls.SetChildIndex(this.button1, 0);
            this.panel1.Controls.SetChildIndex(this.button5, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(0, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColNombre,
            this.ColColPreVen,
            this.ColPreCom,
            this.ColCodDep,
            this.ColCodSup,
            this.ColCodUni,
            this.ColCanExi,
            this.GruArt,
            this.ColPunReo});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(866, 292);
            this.dataGridView1.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(119, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 26);
            this.textBox1.TabIndex = 15;
            this.textBox1.Validar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(8, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 44);
            this.label2.TabIndex = 18;
            this.label2.Text = "CONSULTA ARTICULOS";
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(0, 73);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 39);
            this.button5.TabIndex = 19;
            this.button5.Text = "Imprimir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ColCodigo
            // 
            this.ColCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCodigo.DataPropertyName = "CodArt";
            this.ColCodigo.FillWeight = 3.6129F;
            this.ColCodigo.HeaderText = "Cod.";
            this.ColCodigo.MaxInputLength = 5;
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColNombre
            // 
            this.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombre.DataPropertyName = "NomArt";
            this.ColNombre.FillWeight = 5.6129F;
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MaxInputLength = 20;
            this.ColNombre.MinimumWidth = 20;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColColPreVen
            // 
            this.ColColPreVen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColColPreVen.DataPropertyName = "PreVen";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.ColColPreVen.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColColPreVen.FillWeight = 3.6129F;
            this.ColColPreVen.HeaderText = "Pre. Venta";
            this.ColColPreVen.MaxInputLength = 10;
            this.ColColPreVen.MinimumWidth = 10;
            this.ColColPreVen.Name = "ColColPreVen";
            this.ColColPreVen.ReadOnly = true;
            // 
            // ColPreCom
            // 
            this.ColPreCom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColPreCom.DataPropertyName = "PreCom";
            this.ColPreCom.FillWeight = 3.6129F;
            this.ColPreCom.HeaderText = "Pre. Compra";
            this.ColPreCom.MaxInputLength = 10;
            this.ColPreCom.MinimumWidth = 10;
            this.ColPreCom.Name = "ColPreCom";
            this.ColPreCom.ReadOnly = true;
            // 
            // ColCodDep
            // 
            this.ColCodDep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCodDep.DataPropertyName = "CodDep";
            this.ColCodDep.FillWeight = 3.6129F;
            this.ColCodDep.HeaderText = "Departamento";
            this.ColCodDep.MaxInputLength = 5;
            this.ColCodDep.Name = "ColCodDep";
            this.ColCodDep.ReadOnly = true;
            // 
            // ColCodSup
            // 
            this.ColCodSup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCodSup.DataPropertyName = "CodSup";
            this.ColCodSup.FillWeight = 3.6129F;
            this.ColCodSup.HeaderText = "Suplidor";
            this.ColCodSup.MaxInputLength = 5;
            this.ColCodSup.Name = "ColCodSup";
            this.ColCodSup.ReadOnly = true;
            // 
            // ColCodUni
            // 
            this.ColCodUni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCodUni.DataPropertyName = "CodUni";
            this.ColCodUni.FillWeight = 3.6129F;
            this.ColCodUni.HeaderText = "Unidades";
            this.ColCodUni.MaxInputLength = 5;
            this.ColCodUni.Name = "ColCodUni";
            this.ColCodUni.ReadOnly = true;
            // 
            // ColCanExi
            // 
            this.ColCanExi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCanExi.DataPropertyName = "CanExi";
            this.ColCanExi.FillWeight = 3.6129F;
            this.ColCanExi.HeaderText = "Existente";
            this.ColCanExi.MaxInputLength = 5;
            this.ColCanExi.Name = "ColCanExi";
            this.ColCanExi.ReadOnly = true;
            // 
            // GruArt
            // 
            this.GruArt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GruArt.DataPropertyName = "CodGru";
            this.GruArt.FillWeight = 3.6129F;
            this.GruArt.HeaderText = "Grupo";
            this.GruArt.MaxInputLength = 5;
            this.GruArt.Name = "GruArt";
            this.GruArt.ReadOnly = true;
            // 
            // ColPunReo
            // 
            this.ColPunReo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColPunReo.DataPropertyName = "PunReo";
            this.ColPunReo.FillWeight = 3.6129F;
            this.ColPunReo.HeaderText = "Reorden";
            this.ColPunReo.MaxInputLength = 5;
            this.ColPunReo.Name = "ColPunReo";
            this.ColPunReo.ReadOnly = true;
            // 
            // ConsArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ConsArt";
            this.Text = "ARTICULOS";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private ClassLibrary1.textBox textBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColColPreVen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPreCom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCanExi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GruArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPunReo;
    }
}