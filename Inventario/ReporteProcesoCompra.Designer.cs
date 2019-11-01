namespace Inventario
{
    partial class ReporteProcesoCompra
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD_InventarioDataSet2 = new Inventario.BD_InventarioDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ComprasTableAdapter = new Inventario.BD_InventarioDataSet2TableAdapters.ComprasTableAdapter();
            this.VentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VentasTableAdapter = new Inventario.BD_InventarioDataSet2TableAdapters.VentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_InventarioDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ComprasBindingSource
            // 
            this.ComprasBindingSource.DataMember = "Compras";
            this.ComprasBindingSource.DataSource = this.BD_InventarioDataSet2;
            // 
            // BD_InventarioDataSet2
            // 
            this.BD_InventarioDataSet2.DataSetName = "BD_InventarioDataSet2";
            this.BD_InventarioDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.ComprasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventario.Reporte de compras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(542, 631);
            this.reportViewer1.TabIndex = 1;
            // 
            // ComprasTableAdapter
            // 
            this.ComprasTableAdapter.ClearBeforeFill = true;
            // 
            // VentasBindingSource
            // 
            this.VentasBindingSource.DataMember = "Ventas";
            this.VentasBindingSource.DataSource = this.BD_InventarioDataSet2;
            // 
            // VentasTableAdapter
            // 
            this.VentasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteProcesoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 631);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteProcesoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReporteProcesoCompra";
            this.Load += new System.EventHandler(this.ReporteProcesoCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_InventarioDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ComprasBindingSource;
        private BD_InventarioDataSet2 BD_InventarioDataSet2;
        private BD_InventarioDataSet2TableAdapters.ComprasTableAdapter ComprasTableAdapter;
        private System.Windows.Forms.BindingSource VentasBindingSource;
        private BD_InventarioDataSet2TableAdapters.VentasTableAdapter VentasTableAdapter;
    }
}