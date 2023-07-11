using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulado03__Com_consulta_
{
    public partial class FrmRegistroAcesso : Form
    {

        private SqlConnection conn;

        private List<Veiculo> veiculos = new List<Veiculo>();

        private retornarDados dados;
        public FrmRegistroAcesso()
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
                String placa = maskedTextBox1.Text;
                for (int i = 0; i < veiculos.Count; i++)
                {
                    if (placa.Equals(veiculos[i].Placa))
                    {
                        String placaVeiculo = veiculos[i].Placa;
                        String nomeVeiculo = veiculos[i].NomeVeiculo;
                        String condutor = veiculos[i].Condutor;
                        String tipoVeiculo = veiculos[i].TipoVeiculo;
                        DateTime myDateTime = DateTime.Now;
                        string format = "yyyy-MM-dd HH:mm:ss";
                        MessageBox.Show(myDateTime.ToString());
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO estacionamento (dt_entrada, fk_placa) VALUES (@dt_entrada, @fk_placa)", conn);
                        cmd.Parameters.AddWithValue("@dt_entrada", myDateTime.ToString(format));
                        cmd.Parameters.AddWithValue("@fk_placa", veiculos[i].Placa);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        updateData();
                        break;
                    }
                }

                    if (placa.Equals(""))
                    {
                        throw new Exception("A placa deve ser informada");
                    }
                

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void FrmRegistroAcesso_Load(object sender, EventArgs e)
        {

            updateData();
            
        }

        private void conexao()
        {
            conn = new SqlConnection(@"Data Source=KERNELOS-PC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                validarCampo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                validarCampo();
            }
        }

        public void validarCampo()
        {
            try
            {
                for (int i = 0; i < veiculos.Count; i++)
                {
                    if (maskedTextBox1.Text.Equals(veiculos[i].Placa))
                    {
                        txtCondutor.Text = veiculos[i].Condutor;
                        txtVeiculo.Text = veiculos[i].NomeVeiculo;


                    }
                }

                for (int i2 = 0; i2 < veiculos.Count; i2++)
                {
                    if (maskedTextBox1.Text.Equals(""))
                    {
                        throw new Exception("‘Não existe nenhum veículo vinculado à placa informada’!");
                    }
                    break;
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void updateData()
        {
            conn.Open();
            dtEstacionamento.DataSource = null;
            dtEstacionamento.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT v.placa, v.veiculo, v.condutor, e.dt_entrada FROM veiculos v INNER JOIN estacionamento e on v.placa = e.fk_placa WHERE e.dt_saida IS NULL", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt); 

            dtEstacionamento.DataSource = dt;
            dtEstacionamento.Columns[0].HeaderText = "Placa";
            dtEstacionamento.Columns[1].HeaderText = "Veiculo";
            dtEstacionamento.Columns[2].HeaderText = "Condutor";
            dtEstacionamento.Columns[3].HeaderText = "Data de Entrada";

            bool liberarSaidaColumnExists = false;
            foreach (DataGridViewColumn column in dtEstacionamento.Columns)
            {
                if (column.Name == "liberarBtn")
                {
                    liberarSaidaColumnExists = true;
                    break;
                }
            }


            if (!liberarSaidaColumnExists)
            {
                DataGridViewButtonColumn liberarSaida = new DataGridViewButtonColumn();
                {
                    liberarSaida.Name = "liberarBtn";
                    liberarSaida.HeaderText = "Ações";
                    liberarSaida.Text = "Liberar Saída";
                    liberarSaida.UseColumnTextForButtonValue = true; //dont forget this line
                    this.dtEstacionamento.Columns.Add(liberarSaida);
                }
            }

            dtEstacionamento.Refresh();

            conn.Close();
        }
            
        private void dtEstacionamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String placaVeiculo = dtEstacionamento.Rows[e.RowIndex].Cells[0].Value.ToString();
            String veiculo = dtEstacionamento.Rows[e.RowIndex].Cells[1].Value.ToString();
            String condutor = dtEstacionamento.Rows[e.RowIndex].Cells[2].Value.ToString();
            DateTime dataEntrada = Convert.ToDateTime(dtEstacionamento.Rows[e.RowIndex].Cells[3].Value.ToString());
            DateTime now = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE estacionamento SET dt_saida = @dt_saida WHERE fk_placa = @fk_placa", conn);
            cmd.Parameters.AddWithValue("@dt_saida", now.ToString(format));
            cmd.Parameters.AddWithValue("@fk_placa", placaVeiculo);
            
            cmd.ExecuteNonQuery();
            conn.Close(); 
            MessageBox.Show(dataEntrada.ToString());
        }
        
        


    }

}
