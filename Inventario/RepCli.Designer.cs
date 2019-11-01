namespace Inventario
{
    partial class RepCli
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
            this.ClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD_InventarioDataSet = new Inventario.BD_InventarioDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClientesTableAdapter = new Inventario.BD_InventarioDataSetTableAdapters.ClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_InventarioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientesBindingSource
            // 
            this.ClientesBindingSource.DataMember = "Clientes";
            this.ClientesBindingSource.DataSource = this.BD_InventarioDataSet;
            // 
            // BD_InventarioDataSet
            // 
            this.BD_InventarioDataSet.DataSetName = "BD_InventarioDataSet";
            this.BD_InventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetClientes";
            reportDataSource1.Value = this.ClientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventario.RepCli.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ClientesTableAdapter
            // 
            this.ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // RepCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RepCli";
            this.Text = "RepCli";
            this.Load += new System.EventHandler(this.RepCli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_InventarioDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ClientesBindingSource;
        private BD_InventarioDataSet BD_InventarioDataSet;
        private BD_InventarioDataSetTableAdapters.ClientesTableAdapter ClientesTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}