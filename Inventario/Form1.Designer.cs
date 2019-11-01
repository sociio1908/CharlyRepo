namespace Inventario
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.letras_btn = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.voz_btn = new System.Windows.Forms.Button();
            this.numero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_letras = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO";
            // 
            // letras_btn
            // 
            this.letras_btn.BackColor = System.Drawing.Color.Teal;
            this.letras_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.letras_btn.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letras_btn.ForeColor = System.Drawing.Color.White;
            this.letras_btn.Location = new System.Drawing.Point(129, 272);
            this.letras_btn.Name = "letras_btn";
            this.letras_btn.Size = new System.Drawing.Size(130, 40);
            this.letras_btn.TabIndex = 2;
            this.letras_btn.Text = "Texto";
            this.letras_btn.UseVisualStyleBackColor = false;
            this.letras_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Teal;
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(195, 318);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(130, 40);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "FUNCIONES:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(125, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "NUMERO EN LETRAS Y VOZ";
            // 
            // voz_btn
            // 
            this.voz_btn.BackColor = System.Drawing.Color.Teal;
            this.voz_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voz_btn.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voz_btn.ForeColor = System.Drawing.Color.White;
            this.voz_btn.Location = new System.Drawing.Point(265, 272);
            this.voz_btn.Name = "voz_btn";
            this.voz_btn.Size = new System.Drawing.Size(131, 40);
            this.voz_btn.TabIndex = 7;
            this.voz_btn.Text = "Voz";
            this.voz_btn.UseVisualStyleBackColor = false;
            this.voz_btn.Click += new System.EventHandler(this.salir_btn_Click);
            // 
            // numero
            // 
            this.numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(166, 82);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(190, 26);
            this.numero.TabIndex = 8;
            this.numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "RESULTADO";
            // 
            // btn_letras
            // 
            this.btn_letras.BackColor = System.Drawing.Color.Teal;
            this.btn_letras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_letras.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_letras.ForeColor = System.Drawing.Color.White;
            this.btn_letras.Location = new System.Drawing.Point(30, 208);
            this.btn_letras.Name = "btn_letras";
            this.btn_letras.Size = new System.Drawing.Size(130, 40);
            this.btn_letras.TabIndex = 2;
            this.btn_letras.Text = "Letras";
            this.btn_letras.UseVisualStyleBackColor = false;
            this.btn_letras.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(101, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // resultado
            // 
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(37, 135);
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            this.resultado.Size = new System.Drawing.Size(445, 100);
            this.resultado.TabIndex = 10;
            this.resultado.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 386);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.letras_btn);
            this.Controls.Add(this.voz_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(342, 352);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUMERO A VOZ ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button voz_btn;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button letras_btn;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_letras;
        private System.Windows.Forms.RichTextBox resultado;
    }
}

