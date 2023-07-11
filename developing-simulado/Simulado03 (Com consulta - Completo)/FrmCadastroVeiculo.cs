using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulado03__Com_consulta_
{
    public partial class FrmCadastroVeiculo : Form
    {

        private Veiculo veiculo;

        private SqlConnection conn;

        private List<Veiculo> veiculos = new List<Veiculo>();

        private Veiculo veiculoAlteracao;

        private Boolean alteracaoOk = false;

        private retornarDados dados;

        int id = 0;
        public FrmCadastroVeiculo()
        {
            InitializeComponent();
            conexao();
            veiculos = retornarDados.getVeiculos();
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
               
                String placa = maskPlaca.Text;
                String modelo = txtModelo.Text;
                String condutor = txtCondutor.Text;
                String tipo = cbTipo.Text;
                if (placa.Length <= 0)
                {
                    throw new Exception("O campo não pode estar vazio!");
                }

                if (modelo.Length < 0)
                {
                    throw new Exception("O campo não pode estar vazio!");
                }

                if (condutor.Length < 0)
                {
                    throw new Exception("O campo não pode estar vazio!");
                }

                if (tipo.Length < 0)
                {
                    throw new Exception("O campo é de múltipla escolha e não pode estar vazio!");
                }
                veiculo = new Veiculo(placa, modelo, condutor, tipo);



                if (alteracaoOk == true)
                {
                    editarDados(veiculo);
                }

                for (int i = 0; i < veiculos.Count; i++)
                {
                    
                    if (veiculos[i].Placa.Equals(veiculo.Placa))
                    {
                        alteracaoOk = true;
                        getVeiculoAlteracao(veiculo);
                        throw new Exception("Placa já existente no sistema, alterando para modo de edição.");

                    }
                }

                MessageBox.Show(alteracaoOk.ToString());
                if(alteracaoOk == false)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO veiculos values (@placa, @veiculo, @condutor, @tipo)", conn);

                    cmd.Parameters.AddWithValue("@placa", veiculo.Placa);
                    cmd.Parameters.AddWithValue("@veiculo", veiculo.NomeVeiculo);
                    cmd.Parameters.AddWithValue("@condutor", veiculo.Condutor);
                    cmd.Parameters.AddWithValue("@tipo", veiculo.TipoVeiculo);
                    cmd.ExecuteNonQuery();
                    veiculos = retornarDados.getVeiculos();
                    MessageBox.Show("Veículo cadastrado com sucesso!");
                }
               
                







            }
            catch (Exception e2)
            {
                MessageBox.Show("Ocorreu um erro ao inserir o veiculo. Motivo: " + e2.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void conexao()
        {
            conn = new SqlConnection(@"Data Source=KERNELOS-PC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            while (id == 0)
            {
                cbTipo.Items.RemoveAt(0);
                id++;
            }

        }

        private void maskPlaca_Leave(object sender, EventArgs e)
        {
            validarCampo();

        }

      

        public void validarCampo()
        {
            String placa = maskPlaca.Text;
            try
            {
                if (maskPlaca.Equals(""))
                {
                    throw new Exception("O nome do veiculo está vazio. Preencha algo para realizar a busca.");
                }
                else
                {
                    for (int i = 0; i < veiculos.Count; i++)

                        if (placa.Equals(veiculos[i].Placa))
                        {
                            maskPlaca.Text = veiculos[i].Placa; 
                            txtCondutor.Text = veiculos[i].Condutor;
                            txtModelo.Text = veiculos[i].NomeVeiculo;
                            cbTipo.Text = veiculos[i].TipoVeiculo;
                            break;
                        } else
                        {
                            txtCondutor.Text = "";
                            txtModelo.Text = "";
                            cbTipo.Text = "";
                        }
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void maskPlaca_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                validarCampo();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Cancelar Dados", "Você tem certeza que deseja cancelar os dados preenchidos?", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                txtCondutor.Text = "";
                txtModelo.Text = "";
                maskPlaca.Text = "";
                cbTipo.Text = "";

            } else
            {
                

            }
        }

        public void editarDados(Veiculo veiculo)
        {
            conn.Open();
            Veiculo veiculoAnterior = veiculoAlteracao;
            SqlCommand cmd = new SqlCommand("UPDATE veiculos SET placa = @placa, veiculo = @veiculo, condutor = @condutor, tipo = @tipo WHERE placa = @placaAnterior", conn);
            cmd.Parameters.AddWithValue("@placa", veiculo.Placa);
            cmd.Parameters.AddWithValue("@veiculo", veiculo.NomeVeiculo);
            cmd.Parameters.AddWithValue("@condutor", veiculo.Condutor);
            cmd.Parameters.AddWithValue("@tipo", veiculo.TipoVeiculo);
            cmd.Parameters.AddWithValue("@placaAnterior", veiculoAnterior.Placa);
            cmd.ExecuteNonQuery();
            alteracaoOk = false;
            conn.Close();
            
           
        }

        public Veiculo getVeiculoAlteracao(Veiculo veiculo)
        {
            veiculoAlteracao = veiculo;
            return veiculoAlteracao;
        }

      
      
    }
            

    
}
