namespace Simulado03__Com_consulta_
{
    partial class FrmRegistroAcesso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.txtCondutor = new System.Windows.Forms.TextBox();
            this.btnLiberar = new System.Windows.Forms.Button();
            this.dtEstacionamento = new System.Windows.Forms.DataGridView();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estacionamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estacionamentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtEstacionamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Condutor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ocupação do Estacionamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(415, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------------------";
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(90, 122);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(555, 20);
            this.txtVeiculo.TabIndex = 6;
            // 
            // txtCondutor
            // 
            this.txtCondutor.Location = new System.Drawing.Point(90, 152);
            this.txtCondutor.Name = "txtCondutor";
            this.txtCondutor.Size = new System.Drawing.Size(555, 20);
            this.txtCondutor.TabIndex = 7;
            // 
            // btnLiberar
            // 
            this.btnLiberar.Location = new System.Drawing.Point(693, 151);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(95, 21);
            this.btnLiberar.TabIndex = 8;
            this.btnLiberar.Text = "Liberar Entrada";
            this.btnLiberar.UseVisualStyleBackColor = true;
            this.btnLiberar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtEstacionamento
            // 
            this.dtEstacionamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEstacionamento.Location = new System.Drawing.Point(12, 273);
            this.dtEstacionamento.Name = "dtEstacionamento";
            this.dtEstacionamento.Size = new System.Drawing.Size(776, 165);
            this.dtEstacionamento.TabIndex = 9;
            this.dtEstacionamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtEstacionamento_CellContentClick);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(90, 91);
            this.maskedTextBox1.Mask = "LLL-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(74, 20);
            this.maskedTextBox1.TabIndex = 10;
            this.maskedTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyDown);
            this.maskedTextBox1.Leave += new System.EventHandler(this.maskedTextBox1_Leave);
            // 
            // veiculoBindingSource
            // 
            this.veiculoBindingSource.DataSource = typeof(Simulado03__Com_consulta_.Veiculo);
            // 
            // estacionamentoBindingSource
            // 
            this.estacionamentoBindingSource.DataSource = typeof(Simulado03__Com_consulta_.Estacionamento);
            // 
            // estacionamentoBindingSource1
            // 
            this.estacionamentoBindingSource1.DataSource = typeof(Simulado03__Com_consulta_.Estacionamento);
            // 
            // FrmRegistroAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.dtEstacionamento);
            this.Controls.Add(this.btnLiberar);
            this.Controls.Add(this.txtCondutor);
            this.Controls.Add(this.txtVeiculo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistroAcesso";
            this.Text = "FrmRegistroAcesso";
            this.Load += new System.EventHandler(this.FrmRegistroAcesso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtEstacionamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estacionamentoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.TextBox txtCondutor;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.DataGridView dtEstacionamento;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private System.Windows.Forms.BindingSource estacionamentoBindingSource;
        private System.Windows.Forms.BindingSource estacionamentoBindingSource1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}