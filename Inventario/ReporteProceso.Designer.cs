﻿namespace Inventario
{
    partial class ReporteProceso
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
            this.VentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD_InventarioDataSet2 = new Inventario.BD_InventarioDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VentasTableAdapter = new Inventario.BD_InventarioDataSet2TableAdapters.VentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_InventarioDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // VentasBindingSource
            // 
            this.VentasBindingSource.DataMember = "Ventas";
            this.VentasBindingSource.DataSource = this.BD_InventarioDataSet2;
            // 
            // BD_InventarioDataSet2
            // 
            this.BD_InventarioDataSet2.DataSetName = "BD_InventarioDataSet2";
            this.BD_InventarioDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReporteComprasVentas";
            reportDataSource1.Value = this.VentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventario.Reporte de Ventas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(522, 663);
            this.reportViewer1.TabIndex = 0;
            // 
            // VentasTableAdapter
            // 
            this.VentasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 663);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteProceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReporteProceso";
            this.Load += new System.EventHandler(this.ReporteProceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_InventarioDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VentasBindingSource;
        private BD_InventarioDataSet2 BD_InventarioDataSet2;
        private BD_InventarioDataSet2TableAdapters.VentasTableAdapter VentasTableAdapter;
    }
}