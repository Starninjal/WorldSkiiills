namespace Simulado01__Sem_Consulta_
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heheToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.converterCâmbioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heheToolStripMenuItem,
            this.conversãoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heheToolStripMenuItem
            // 
            this.heheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heheToolStripMenuItem1});
            this.heheToolStripMenuItem.Name = "heheToolStripMenuItem";
            this.heheToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.heheToolStripMenuItem.Text = "Cadastros";
            this.heheToolStripMenuItem.Click += new System.EventHandler(this.heheToolStripMenuItem_Click);
            // 
            // heheToolStripMenuItem1
            // 
            this.heheToolStripMenuItem1.Name = "heheToolStripMenuItem1";
            this.heheToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.heheToolStripMenuItem1.Text = "Base De Conversão";
            this.heheToolStripMenuItem1.Click += new System.EventHandler(this.heheToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // conversãoToolStripMenuItem
            // 
            this.conversãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.converterCâmbioToolStripMenuItem});
            this.conversãoToolStripMenuItem.Name = "conversãoToolStripMenuItem";
            this.conversãoToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.conversãoToolStripMenuItem.Text = "Conversão";
            // 
            // converterCâmbioToolStripMenuItem
            // 
            this.converterCâmbioToolStripMenuItem.Name = "converterCâmbioToolStripMenuItem";
            this.converterCâmbioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.converterCâmbioToolStripMenuItem.Text = "Converter Câmbio";
            this.converterCâmbioToolStripMenuItem.Click += new System.EventHandler(this.converterCâmbioToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Câmbio SENAI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heheToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem converterCâmbioToolStripMenuItem;
    }
}

