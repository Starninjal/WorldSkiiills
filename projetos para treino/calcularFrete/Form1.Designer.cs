namespace calcularFrete
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblValorLt = new System.Windows.Forms.Label();
            this.txtValorLitro = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtTabela = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAutonomia = new System.Windows.Forms.TextBox();
            this.lblDistanciaCombustivel = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKmRodado = new System.Windows.Forms.TextBox();
            this.txtCustoKm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDespesa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgLarge = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLarge)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lblValorLt);
            this.panel1.Controls.Add(this.txtValorLitro);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.txtTabela);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtAutonomia);
            this.panel1.Controls.Add(this.lblDistanciaCombustivel);
            this.panel1.Controls.Add(this.txtDistancia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtLocalidade);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtVeiculo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(21, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 249);
            this.panel1.TabIndex = 0;
            // 
            // lblValorLt
            // 
            this.lblValorLt.AutoSize = true;
            this.lblValorLt.Location = new System.Drawing.Point(351, 126);
            this.lblValorLt.Name = "lblValorLt";
            this.lblValorLt.Size = new System.Drawing.Size(86, 16);
            this.lblValorLt.TabIndex = 12;
            this.lblValorLt.Text = "Valor por litro";
            // 
            // txtValorLitro
            // 
            this.txtValorLitro.Location = new System.Drawing.Point(354, 145);
            this.txtValorLitro.Name = "txtValorLitro";
            this.txtValorLitro.Size = new System.Drawing.Size(144, 22);
            this.txtValorLitro.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 190);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 20);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Ida / Volta";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtTabela
            // 
            this.txtTabela.Location = new System.Drawing.Point(183, 145);
            this.txtTabela.Name = "txtTabela";
            this.txtTabela.Size = new System.Drawing.Size(144, 22);
            this.txtTabela.TabIndex = 9;
            this.txtTabela.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tabela";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtAutonomia
            // 
            this.txtAutonomia.Location = new System.Drawing.Point(17, 145);
            this.txtAutonomia.Name = "txtAutonomia";
            this.txtAutonomia.Size = new System.Drawing.Size(144, 22);
            this.txtAutonomia.TabIndex = 7;
            // 
            // lblDistanciaCombustivel
            // 
            this.lblDistanciaCombustivel.AutoSize = true;
            this.lblDistanciaCombustivel.Location = new System.Drawing.Point(14, 126);
            this.lblDistanciaCombustivel.Name = "lblDistanciaCombustivel";
            this.lblDistanciaCombustivel.Size = new System.Drawing.Size(148, 16);
            this.lblDistanciaCombustivel.TabIndex = 6;
            this.lblDistanciaCombustivel.Text = "Autonomia Combustível";
            this.lblDistanciaCombustivel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(354, 75);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(144, 22);
            this.txtDistancia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Distância KM";
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Location = new System.Drawing.Point(183, 75);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.Size = new System.Drawing.Size(144, 22);
            this.txtLocalidade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Localidade";
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(17, 75);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(144, 22);
            this.txtVeiculo.TabIndex = 1;
            this.txtVeiculo.Leave += new System.EventHandler(this.txtVeiculo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veículo";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnConfirmar.Location = new System.Drawing.Point(24, 309);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(127, 32);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 380);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 22);
            this.textBox1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Consumo de Combustível";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "KM rodado";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtKmRodado
            // 
            this.txtKmRodado.Location = new System.Drawing.Point(12, 474);
            this.txtKmRodado.Name = "txtKmRodado";
            this.txtKmRodado.Size = new System.Drawing.Size(144, 22);
            this.txtKmRodado.TabIndex = 15;
            // 
            // txtCustoKm
            // 
            this.txtCustoKm.Location = new System.Drawing.Point(212, 474);
            this.txtCustoKm.Name = "txtCustoKm";
            this.txtCustoKm.Size = new System.Drawing.Size(144, 22);
            this.txtCustoKm.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Custo por KM";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDespesa
            // 
            this.txtDespesa.Location = new System.Drawing.Point(497, 380);
            this.txtDespesa.Name = "txtDespesa";
            this.txtDespesa.Size = new System.Drawing.Size(123, 22);
            this.txtDespesa.TabIndex = 19; 
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Despesa de Combustível";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(385, 474);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 22);
            this.textBox3.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(642, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 185);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // imgLarge
            // 
            this.imgLarge.Location = new System.Drawing.Point(567, 54);
            this.imgLarge.Name = "imgLarge";
            this.imgLarge.Size = new System.Drawing.Size(366, 249);
            this.imgLarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLarge.TabIndex = 23;
            this.imgLarge.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(945, 537);
            this.Controls.Add(this.imgLarge);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDespesa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCustoKm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKmRodado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLarge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTabela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAutonomia;
        private System.Windows.Forms.Label lblDistanciaCombustivel;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKmRodado;
        private System.Windows.Forms.TextBox txtCustoKm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDespesa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgLarge;
        private System.Windows.Forms.Label lblValorLt;
        private System.Windows.Forms.TextBox txtValorLitro;
    }
}

