﻿namespace CambioSenai
{
    partial class frmConverter
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorConverter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorConvertido = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cbMoeda = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moeda";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 80);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "v";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 80);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 3;
            this.button2.Text = "Novo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Base de Conversão";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(140, 110);
            this.txtBase.Margin = new System.Windows.Forms.Padding(2);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(76, 20);
            this.txtBase.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor para Conversão";
            // 
            // txtValorConverter
            // 
            this.txtValorConverter.Location = new System.Drawing.Point(140, 150);
            this.txtValorConverter.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorConverter.Name = "txtValorConverter";
            this.txtValorConverter.Size = new System.Drawing.Size(76, 20);
            this.txtValorConverter.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor Convertido";
            // 
            // txtValorConvertido
            // 
            this.txtValorConvertido.Location = new System.Drawing.Point(140, 188);
            this.txtValorConvertido.Margin = new System.Windows.Forms.Padding(2);
            this.txtValorConvertido.Name = "txtValorConvertido";
            this.txtValorConvertido.Size = new System.Drawing.Size(61, 20);
            this.txtValorConvertido.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 301);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 32);
            this.button3.TabIndex = 10;
            this.button3.Text = "Calcular";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(392, 301);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 32);
            this.button4.TabIndex = 11;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // cbMoeda
            // 
            this.cbMoeda.FormattingEnabled = true;
            this.cbMoeda.Location = new System.Drawing.Point(140, 79);
            this.cbMoeda.Margin = new System.Windows.Forms.Padding(2);
            this.cbMoeda.Name = "cbMoeda";
            this.cbMoeda.Size = new System.Drawing.Size(224, 21);
            this.cbMoeda.TabIndex = 12;
            this.cbMoeda.SelectedIndexChanged += new System.EventHandler(this.cbMoeda_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(121, 301);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 32);
            this.button5.TabIndex = 13;
            this.button5.Text = "Remover";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cbMoeda);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtValorConvertido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorConverter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConverter";
            this.Text = "Converter Câmbio";
            this.Activated += new System.EventHandler(this.frmConverter_Activated);
            this.Load += new System.EventHandler(this.frmConverter_Load);
            this.Click += new System.EventHandler(this.frmConverter_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorConverter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorConvertido;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cbMoeda;
        private System.Windows.Forms.Button button5;
    }
}