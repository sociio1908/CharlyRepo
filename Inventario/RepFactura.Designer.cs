namespace Inventario
{
    partial class RepFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DatosFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosFactura = new Inventario.DatosFactura();
            this.DatosFacturaCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD_InventarioDataSet1 = new Inventario.BD_InventarioDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatosFacturaTableAdapter = new Inventario.DatosFacturaTableAdapters.DatosFacturaTableAdapter();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.btn_noEnviar = new System.Windows.Forms.Button();
            this.DatosFacturaCompraTableAdapter = new Inventario.BD_InventarioDataSet1TableAdapters.DatosFacturaCompraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFacturaCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_InventarioDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosFacturaBindingSource
            // 
            this.DatosFacturaBindingSource.DataMember = "DatosFactura";
            this.DatosFacturaBindingSource.DataSource = this.DatosFactura;
            // 
            // DatosFactura
            // 
            this.DatosFactura.DataSetName = "DatosFactura";
            this.DatosFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DatosFacturaCompraBindingSource
            // 
            this.DatosFacturaCompraBindingSource.DataMember = "DatosFacturaCompra";
            this.DatosFacturaCompraBindingSource.DataSource = this.BD_InventarioDataSet1;
            // 
            // BD_InventarioDataSet1
            // 
            this.BD_InventarioDataSet1.DataSetName = "BD_InventarioDataSet1";
            this.BD_InventarioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DatosFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventario.FactVen.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(410, 589);
            this.reportViewer1.TabIndex = 0;
            // 
            // DatosFacturaTableAdapter
            // 
            this.DatosFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.BackColor = System.Drawing.Color.White;
            this.btn_Enviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Enviar.Location = new System.Drawing.Point(12, 596);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(172, 37);
            this.btn_Enviar.TabIndex = 1;
            this.btn_Enviar.Text = "ENVIAR POR CORREO";
            this.btn_Enviar.UseVisualStyleBackColor = false;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // btn_noEnviar
            // 
            this.btn_noEnviar.BackColor = System.Drawing.Color.White;
            this.btn_noEnviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_noEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_noEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_noEnviar.Location = new System.Drawing.Point(226, 596);
            this.btn_noEnviar.Name = "btn_noEnviar";
            this.btn_noEnviar.Size = new System.Drawing.Size(172, 37);
            this.btn_noEnviar.TabIndex = 2;
            this.btn_noEnviar.Text = "IMPRIMIR";
            this.btn_noEnviar.UseVisualStyleBackColor = false;
            // 
            // DatosFacturaCompraTableAdapter
            // 
            this.DatosFacturaCompraTableAdapter.ClearBeforeFill = true;
            // 
            // RepFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 645);
            this.Controls.Add(this.btn_noEnviar);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RepFactura";
            this.Text = "RepFactura";
            this.Load += new System.EventHandler(this.RepFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFacturaCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_InventarioDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DatosFacturaBindingSource;
        private DatosFactura DatosFactura;
        private DatosFacturaTableAdapters.DatosFacturaTableAdapter DatosFacturaTableAdapter;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.Button btn_noEnviar;
        private System.Windows.Forms.BindingSource DatosFacturaCompraBindingSource;
        private BD_InventarioDataSet1 BD_InventarioDataSet1;
        private BD_InventarioDataSet1TableAdapters.DatosFacturaCompraTableAdapter DatosFacturaCompraTableAdapter;
    }
}