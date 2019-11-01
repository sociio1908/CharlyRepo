namespace Inventario
{
    partial class Consultas
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
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Salir_btn
            // 
            this.Salir_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Salir_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Salir_btn.Location = new System.Drawing.Point(0, 321);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Consultar_btn);
            this.panel1.Location = new System.Drawing.Point(604, 0);
            this.panel1.Size = new System.Drawing.Size(119, 363);
            this.panel1.Controls.SetChildIndex(this.Salir_btn, 0);
            this.panel1.Controls.SetChildIndex(this.Consultar_btn, 0);
            // 
            // Consultar_btn
            // 
            this.Consultar_btn.BackColor = System.Drawing.Color.White;
            this.Consultar_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Consultar_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Consultar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consultar_btn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.Consultar_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Consultar_btn.Location = new System.Drawing.Point(0, 0);
            this.Consultar_btn.Name = "Consultar_btn";
            this.Consultar_btn.Size = new System.Drawing.Size(119, 38);
            this.Consultar_btn.TabIndex = 1;
            this.Consultar_btn.Text = "Consultar";
            this.Consultar_btn.UseVisualStyleBackColor = false;
            this.Consultar_btn.Click += new System.EventHandler(this.Consultar_btn_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 363);
            this.Name = "Consultas";
            this.PuedeConsultar = true;
            this.Text = "FormConsultas";
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Consultar_btn;
    }
}