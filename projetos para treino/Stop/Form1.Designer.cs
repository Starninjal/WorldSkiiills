namespace Stop
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOkay = new System.Windows.Forms.Button();
            this.chckboxUsuario = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSetUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(315, 361);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(107, 44);
            this.btnOkay.TabIndex = 0;
            this.btnOkay.Text = "Verificar";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // chckboxUsuario
            // 
            this.chckboxUsuario.AutoSize = true;
            this.chckboxUsuario.Location = new System.Drawing.Point(81, 97);
            this.chckboxUsuario.Name = "chckboxUsuario";
            this.chckboxUsuario.Size = new System.Drawing.Size(112, 20);
            this.chckboxUsuario.TabIndex = 1;
            this.chckboxUsuario.Text = "Exibir Usuário";
            this.chckboxUsuario.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(21, 58);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSetUsuario
            // 
            this.lblSetUsuario.AutoSize = true;
            this.lblSetUsuario.Location = new System.Drawing.Point(209, 101);
            this.lblSetUsuario.Name = "lblSetUsuario";
            this.lblSetUsuario.Size = new System.Drawing.Size(16, 16);
            this.lblSetUsuario.TabIndex = 4;
            this.lblSetUsuario.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 467);
            this.Controls.Add(this.lblSetUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chckboxUsuario);
            this.Controls.Add(this.btnOkay);
            this.Name = "Form1";
            this.Text = "f";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.CheckBox chckboxUsuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSetUsuario;
    }
}

