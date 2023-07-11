namespace MeuSistema
{
    partial class frmProduto
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
            System.Windows.Forms.Label lblParcela2;
            this.txtRes = new System.Windows.Forms.TextBox();
            this.txtParcela2 = new System.Windows.Forms.TextBox();
            this.txtParcela1 = new System.Windows.Forms.TextBox();
            this.lblParcela1 = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            lblParcela2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblParcela2
            // 
            lblParcela2.AutoSize = true;
            lblParcela2.Location = new System.Drawing.Point(43, 134);
            lblParcela2.Name = "lblParcela2";
            lblParcela2.Size = new System.Drawing.Size(64, 16);
            lblParcela2.TabIndex = 6;
            lblParcela2.Text = "Parcela 2";
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(113, 162);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(155, 22);
            this.txtRes.TabIndex = 2;
            this.txtRes.Click += new System.EventHandler(this.txtRes_Click);
            // 
            // txtParcela2
            // 
            this.txtParcela2.Location = new System.Drawing.Point(113, 134);
            this.txtParcela2.Name = "txtParcela2";
            this.txtParcela2.Size = new System.Drawing.Size(155, 22);
            this.txtParcela2.TabIndex = 3;
            // 
            // txtParcela1
            // 
            this.txtParcela1.Location = new System.Drawing.Point(113, 100);
            this.txtParcela1.Name = "txtParcela1";
            this.txtParcela1.Size = new System.Drawing.Size(155, 22);
            this.txtParcela1.TabIndex = 4;
            // 
            // lblParcela1
            // 
            this.lblParcela1.AutoSize = true;
            this.lblParcela1.Location = new System.Drawing.Point(43, 100);
            this.lblParcela1.Name = "lblParcela1";
            this.lblParcela1.Size = new System.Drawing.Size(64, 16);
            this.lblParcela1.TabIndex = 5;
            this.lblParcela1.Text = "Parcela 1";
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(43, 165);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(69, 16);
            this.lblRes.TabIndex = 7;
            this.lblRes.Text = "Resultado";
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(lblParcela2);
            this.Controls.Add(this.lblParcela1);
            this.Controls.Add(this.txtParcela1);
            this.Controls.Add(this.txtParcela2);
            this.Controls.Add(this.txtRes);
            this.Name = "frmProduto";
            this.Text = "Top";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.TextBox txtParcela2;
        private System.Windows.Forms.TextBox txtParcela1;
        private System.Windows.Forms.Label lblParcela1;
        private System.Windows.Forms.Label lblRes;
    }
}

