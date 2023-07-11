using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulado03__Com_consulta_
{
    public partial class FrmCadastroVeiculo : Form
    {

        private Veiculo veiculo;

        private SqlConnection conn;

        public FrmCadastroVeiculo()
        {
            InitializeComponent();
            conexao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String placa = txtPlaca.Text;
                String modelo = txtModelo.Text;
                String condutor = txtCondutor.Text;
                String tipo = cbTipo.Text;
                if(placa.Length < 0)
                {
                    throw new Exception("O campo não pode estar vazio!");
                }

                if(modelo.Length < 0)
                {
                    throw new Exception("O campo não pode estar vazio!");
                }

                if(condutor.Length < 0)
                {
                    throw new Exception("O campo não pode estar vazio!");
                }

                if(tipo.Length < 0)
                {
                    throw new Exception("O campo é de múltipla escolha e não pode estar vazio!");
                }
                veiculo = new Veiculo(placa, modelo, condutor, tipo);

                SqlCommand cmd = new SqlCommand("INSERT INTO veiculos values (@placa, @modelo, @condutor, @tipo)", conn);

                cmd.Parameters.AddWithValue("@placa", veiculo.Placa);
                cmd.Parameters.AddWithValue("@modelo", veiculo.NomeVeiculo);
                cmd.Parameters.AddWithValue("@condutor", veiculo.Condutor);
                cmd.Parameters.AddWithValue("@tipo", veiculo.TipoVeiculo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Veículo cadastrado com sucesso!");
            } catch(Exception e2)                                           
            {                                                               
                MessageBox.Show("Ocorreu um erro ao inserir o veiculo. Motivo: " + e2.Message);
            } finally
            {
                conn.Close();
            }
        }

        public void conexao()
        {
            conn = new SqlConnection(@"Data Source=SN-386958\SQLEXPRESS;Initial Catalog=simulado03;Integrated Security=True");
        }
    }
}
