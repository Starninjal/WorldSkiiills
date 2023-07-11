using Entity;
using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulado0333
{
    public partial class frmCadastroVeiculos : Form
    {
        private int contador = 0;

        private List<veiculos> veiculosList = new List<veiculos>();
        public frmCadastroVeiculos()
        {
            InitializeComponent();
        }

        veiculos model = new veiculos();

        private void frmCadastroVeiculos_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           
            model.placa = maskedTextBox1.Text;
            model.veiculo = textBox2.Text;
            model.condutor = textBox3.Text;
            model.tipo = cbTipo.Text;
            
            
                try
                {
                    using (masterEntities db = new masterEntities())
                    {
                        validarDados(model);
                        db.veiculos.Add(model);
                        db.SaveChanges();

                        MessageBox.Show("Veiculo inserido com sucesso!");
                    }
                } catch(Exception e2)
                {

                    MessageBox.Show("Ocorreu um erro! " + e2.Message);
                }
            
            
        }

        public void validarDados(veiculos veiculos)
        {
            if(veiculos != null)
            {

                if (maskedTextBox1.Text != maskedTextBox1.Text.ToUpper())
                {
                    throw new Exception("Os caracteres devem ser maiusculos!");
                }

                if(veiculos.veiculo == veiculos.veiculo.Concat(veiculos.veiculo.Where(char.IsLetterOrDigit))) {
                    throw new Exception("O modelo deve conter apenas letras e numeros");
                }

                

                
                           
            }
        }
        
        public void setarListar()
        {
            using (masterEntities db = new masterEntities())
            {
                veiculosList = db.veiculos.ToList();
            }

            for (int i = 0; i < veiculosList.Count; i++)
            {
                MessageBox.Show(veiculosList[i].placa);
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            setarListar();
        }
    }

    
}
