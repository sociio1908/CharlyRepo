namespace Inventario
{
    partial class RepSup
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
            this.SuplidoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD_InventarioDataSet = new Inventario.BD_InventarioDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuplidoresTableAdapter = new Inventario.BD_InventarioDataSetTableAdapters.SuplidoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SuplidoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_InventarioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SuplidoresBindingSource
            // 
            this.SuplidoresBindingSource.DataMember = "Suplidores";
            this.SuplidoresBindingSource.DataSource = this.BD_InventarioDataSet;
            // 
            // BD_InventarioDataSet
            // 
            this.BD_InventarioDataSet.DataSetName = "BD_InventarioDataSet";
            this.BD_InventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetSuplidor";
            reportDataSource1.Value = this.SuplidoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventario.RepSup.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // SuplidoresTableAdapter
            // 
            this.SuplidoresTableAdapter.ClearBeforeFill = true;
            // 
            // RepSup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RepSup";
            this.Text = "RepSup";
            this.Load += new System.EventHandler(this.RepSup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SuplidoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_InventarioDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource SuplidoresBindingSource;
        private BD_InventarioDataSet BD_InventarioDataSet;
        private BD_InventarioDataSetTableAdapters.SuplidoresTableAdapter SuplidoresTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}