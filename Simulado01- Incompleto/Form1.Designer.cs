namespace CambioSenai
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeConversãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.converterValorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.converterValorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.conversãoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDeConversãoToolStripMenuItem,
            this.converterValorToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // baseDeConversãoToolStripMenuItem
            // 
            this.baseDeConversãoToolStripMenuItem.Name = "baseDeConversãoToolStripMenuItem";
            this.baseDeConversãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.baseDeConversãoToolStripMenuItem.Text = "Base De Conversão";
            this.baseDeConversãoToolStripMenuItem.Click += new System.EventHandler(this.baseDeConversãoToolStripMenuItem_Click);
            // 
            // converterValorToolStripMenuItem
            // 
            this.converterValorToolStripMenuItem.Name = "converterValorToolStripMenuItem";
            this.converterValorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.converterValorToolStripMenuItem.Text = "Converter valor";
            this.converterValorToolStripMenuItem.Click += new System.EventHandler(this.converterValorToolStripMenuItem_Click);
            // 
            // conversãoToolStripMenuItem
            // 
            this.conversãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.converterValorToolStripMenuItem1});
            this.conversãoToolStripMenuItem.Name = "conversãoToolStripMenuItem";
            this.conversãoToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.conversãoToolStripMenuItem.Text = "Conversão";
            this.conversãoToolStripMenuItem.Click += new System.EventHandler(this.conversãoToolStripMenuItem_Click);
            // 
            // converterValorToolStripMenuItem1
            // 
            this.converterValorToolStripMenuItem1.Name = "converterValorToolStripMenuItem1";
            this.converterValorToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.converterValorToolStripMenuItem1.Text = "Converter Valor";
            this.converterValorToolStripMenuItem1.Click += new System.EventHandler(this.converterValorToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Câmbio SENAI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeConversãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem converterValorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem converterValorToolStripMenuItem1;
    }
}

