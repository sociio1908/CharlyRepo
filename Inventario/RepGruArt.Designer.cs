namespace Inventario
{
    partial class RepGruArt
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
            this.GruposArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GrupoArticulos = new Inventario.GrupoArticulos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.GruposArticulosTableAdapter = new Inventario.GrupoArticulosTableAdapters.GruposArticulosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GruposArticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // GruposArticulosBindingSource
            // 
            this.GruposArticulosBindingSource.DataMember = "GruposArticulos";
            this.GruposArticulosBindingSource.DataSource = this.GrupoArticulos;
            // 
            // GrupoArticulos
            // 
            this.GrupoArticulos.DataSetName = "GrupoArticulos";
            this.GrupoArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.GruposArticulosBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Inventario.RepGruArt.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(691, 543);
            this.reportViewer2.TabIndex = 0;
            // 
            // GruposArticulosTableAdapter
            // 
            this.GruposArticulosTableAdapter.ClearBeforeFill = true;
            // 
            // RepGruArt
            // 
            this.ClientSize = new System.Drawing.Size(691, 543);
            this.Controls.Add(this.reportViewer2);
            this.Name = "RepGruArt";
            this.Load += new System.EventHandler(this.RepGruArt_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GruposArticulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupoArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GruposArticulosBindingSource;
        private GrupoArticulos GrupoArticulos;
        private GrupoArticulosTableAdapters.GruposArticulosTableAdapter GruposArticulosTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}