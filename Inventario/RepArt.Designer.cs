namespace Inventario
{
    partial class RepArt
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
            this.ArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD_InventarioDataSet = new Inventario.BD_InventarioDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ArticulosTableAdapter = new Inventario.BD_InventarioDataSetTableAdapters.ArticulosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ArticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_InventarioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ArticulosBindingSource
            // 
            this.ArticulosBindingSource.DataMember = "Articulos";
            this.ArticulosBindingSource.DataSource = this.BD_InventarioDataSet;
            // 
            // BD_InventarioDataSet
            // 
            this.BD_InventarioDataSet.DataSetName = "BD_InventarioDataSet";
            this.BD_InventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataArticulos";
            reportDataSource1.Value = this.ArticulosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventario.ReporteArticulo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(530, 364);
            this.reportViewer1.TabIndex = 0;
            // 
            // ArticulosTableAdapter
            // 
            this.ArticulosTableAdapter.ClearBeforeFill = true;
            // 
            // RepArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 364);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RepArt";
            this.Text = "REPORTE";
            this.Load += new System.EventHandler(this.RepArt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArticulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_InventarioDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ArticulosBindingSource;
        private BD_InventarioDataSet BD_InventarioDataSet;
        private BD_InventarioDataSetTableAdapters.ArticulosTableAdapter ArticulosTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}