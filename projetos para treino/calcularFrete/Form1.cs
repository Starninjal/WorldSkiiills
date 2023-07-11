using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcularFrete
{
    public partial class Form1 : Form
    {

        private double kmRodado = 0;

        private double kmAutonomia = 0;

        private double qtdCombustivel;

        private double custoCombustivel = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtVeiculo_Leave(object sender, EventArgs e)
        {
            if (txtVeiculo.Text == "Audi")
            {
                imgLarge.Image = calcularFrete.Properties.Resources.audi;   
            } else if(txtVeiculo.Text == "audi q4")
            {
                imgLarge.Image = calcularFrete.Properties.Resources.audi_q4;
            } else if(txtVeiculo.Text == "bmw")
            {
                imgLarge.Image = calcularFrete.Properties.Resources.bm1;
            } else
            {
                MessageBox.Show("Você não tem esse veículo!");
                txtVeiculo.Text = "";
                txtVeiculo.Focus();
            }
           
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            kmRodado = Double.Parse(txtDistancia.Text);   

            if(checkBox1.Checked == false)
            {
                kmRodado = kmRodado * 1;
            } else
            {
                kmRodado *= 2;
            }

            //consumo do combustível

            

            qtdCombustivel = kmRodado / Double.Parse(txtAutonomia.Text); 

            custoCombustivel =double.Parse(txtValorLitro.Text) * qtdCombustivel;

            txtDespesa.Text = custoCombustivel.ToString();



            // 
        }

       
    } 
}
