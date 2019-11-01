namespace Inventario
{
    partial class FormConsultas
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
            this.Consultar_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Consultar_btn);
            this.panel1.Location = new System.Drawing.Point(681, 0);
            this.panel1.Size = new System.Drawing.Size(119, 450);
            this.panel1.Controls.SetChildIndex(this.Salir_btn, 0);
            this.panel1.Controls.SetChildIndex(this.Consultar_btn, 0);
            // 
            // Salir_btn
            // 
            this.Salir_btn.Location = new System.Drawing.Point(0, 408);
            // 
            // Consultar_btn
            // 
            this.Consultar_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Consultar_btn.Location = new System.Drawing.Point(0, 370);
            this.Consultar_btn.Name = "Consultar_btn";
            this.Consultar_btn.Size = new System.Drawing.Size(119, 38);
            this.Consultar_btn.TabIndex = 1;
            this.Consultar_btn.Text = "Consultar";
            this.Consultar_btn.UseVisualStyleBackColor = true;
            // 
            // FormConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormConsultas";
            this.Text = "FormConsultas";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Consultar_btn;
    }
}