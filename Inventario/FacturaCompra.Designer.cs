namespace Inventario
{
    partial class FacturaCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturaCompra));
            this.DatosFacturaCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD_InventarioDataSet1 = new Inventario.BD_InventarioDataSet1();
            this.btn_noimprimir = new System.Windows.Forms.Button();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatosFacturaCompraTableAdapter = new Inventario.BD_InventarioDataSet1TableAdapters.DatosFacturaCompraTableAdapter();
            this.DatosFactura = new Inventario.DatosFactura();
            this.DatosFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosFacturaTableAdapter = new Inventario.DatosFacturaTableAdapters.DatosFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFacturaCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_InventarioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // btn_noimprimir
            // 
            this.btn_noimprimir.BackColor = System.Drawing.Color.White;
            this.btn_noimprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_noimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_noimprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_noimprimir.Location = new System.Drawing.Point(228, 595);
            this.btn_noimprimir.Name = "btn_noimprimir";
            this.btn_noimprimir.Size = new System.Drawing.Size(172, 37);
            this.btn_noimprimir.TabIndex = 5;
            this.btn_noimprimir.Text = "IMPRIMIR";
            this.btn_noimprimir.UseVisualStyleBackColor = false;
            this.btn_noimprimir.Click += new System.EventHandler(this.btn_noimprimir_Click);
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.White;
            this.btn_enviar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_enviar.Location = new System.Drawing.Point(12, 595);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(172, 37);
            this.btn_enviar.TabIndex = 4;
            this.btn_enviar.Text = "ENVIAR POR CORREO";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DatosFacturaCompraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventario.FactCompra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("", System.UriKind.Relative);
            this.reportViewer1.Size = new System.Drawing.Size(415, 589);
            this.reportViewer1.TabIndex = 6;
            // 
            // DatosFacturaCompraTableAdapter
            // 
            this.DatosFacturaCompraTableAdapter.ClearBeforeFill = true;
            // 
            // DatosFactura
            // 
            this.DatosFactura.DataSetName = "DatosFactura";
            this.DatosFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DatosFacturaBindingSource
            // 
            this.DatosFacturaBindingSource.DataMember = "DatosFactura";
            this.DatosFacturaBindingSource.DataSource = this.DatosFactura;
            // 
            // DatosFacturaTableAdapter
            // 
            this.DatosFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // FacturaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(412, 643);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_noimprimir);
            this.Controls.Add(this.btn_enviar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacturaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FacturaCompra";
            this.Load += new System.EventHandler(this.FacturaCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosFacturaCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_InventarioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_noimprimir;
        private System.Windows.Forms.Button btn_enviar;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DatosFacturaCompraBindingSource;
        private BD_InventarioDataSet1 BD_InventarioDataSet1;
        private BD_InventarioDataSet1TableAdapters.DatosFacturaCompraTableAdapter DatosFacturaCompraTableAdapter;
        private System.Windows.Forms.BindingSource DatosFacturaBindingSource;
        private DatosFactura DatosFactura;
        private DatosFacturaTableAdapters.DatosFacturaTableAdapter DatosFacturaTableAdapter;
    }
}