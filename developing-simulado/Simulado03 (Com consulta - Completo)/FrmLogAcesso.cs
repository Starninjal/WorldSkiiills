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
    public partial class FrmLogAcesso : Form
    {

        private SqlConnection conn;

        private static int qtdMoto;

        private static int qtdCarro;

        private int idAvailable = 0;
        private static int qtdAcessos;

        private retornarDados dados;

        private DateTime dataFinal;

        private DateTime dataInicial;

        private String dataInicialText;

        private String dataFinalText;
        public FrmLogAcesso()
        {
            InitializeComponent();
            conexao();
            lblCarro.Text = retornarDados.getQtdCarro().ToString();
            lblMoto.Text = retornarDados.getQtdMoto().ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

                try
                {
                    
                    dataInicial = Convert.ToDateTime(maskDataInicial.Text);
                    
                    dataFinal = Convert.ToDateTime(maskDataFinal.Text);

                    dataInicialText = maskDataFinal.Text;

                    dataFinalText = maskDataFinal.Text;

                    if (dataFinal < dataInicial)
                    {
                        throw new Exception("A data final não pode ser menor que a data inicial");
                    }

                       idAvailable = 1;

                }
                catch (Exception e2)
                {

                MessageBox.Show(dataInicial.ToString("yyyy-dd-MM HH:mm:ss.fff"));

                String data = dataInicial.ToString("yyyy-dd-MM HH:mm:ss.fff");

                try
                {
                    if (dataInicial.ToString("yyyy-dd-MM HH:mm:ss.fff").Equals("2023-09-07 00:00:00.000"))
                    {
                        throw new Exception("A data inicial não deve estar vazia.");
                    }
                    else
                    {
                        if (dataInicial > dataFinal)
                        {
                            throw new Exception("A data inicial não pode ser maior que a data final.");
                        }
                        else
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("SELECT v.placa, v.veiculo, v.condutor, v.tipo, e.dt_entrada, e.dt_saida, " +
                               "CONCAT( DATEDIFF(HOUR, e.dt_entrada, e.dt_saida), 'h:', " +
                               "DATEPART(MINUTE, e.dt_entrada) - DATEPART(MINUTE, e.dt_saida), 'min:', DATEPART(SECOND, e.dt_saida) - DATEPART(SECOND, e.dt_entrada), 's' )" +
                               "AS diferenca_horas_minutos_segundos FROM estacionamento e INNER JOIN veiculos v on v.placa = e.fk_placa WHERE dt_entrada > = @dataInicial and v.tipo = @tipoSelecionado", conn);
                            cmd.Parameters.AddWithValue("@dataInicial", dataInicial.ToString("yyyy-dd-MM HH:mm:ss.fff"));
                            cmd.Parameters.AddWithValue("@tipoSelecionado", comboBox1.Text);
                            SqlDataAdapter da = new SqlDataAdapter();
                            da.SelectCommand = cmd;
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                            dataGridView1.Columns[0].HeaderText = "Placa";
                            dataGridView1.Columns[1].HeaderText = "Veículo";
                            dataGridView1.Columns[2].HeaderText = "Condutor";
                            dataGridView1.Columns[3].HeaderText = "Tipo de Veiculo";
                            dataGridView1.Columns[4].HeaderText = "Data de Entrada";
                            dataGridView1.Columns[5].HeaderText = "Data de Saída";
                            dataGridView1.Columns[6].HeaderText = "Permanência do Veículo";
                            updateDados();
                            qtdAcessos++;
                            lblAcessos.Text = qtdAcessos.ToString();
                            conn.Close();
                        }
                    }
                } catch(Exception e3)
                {
                    MessageBox.Show(e3.Message);
                }
                

                

          

                    
                
                }



            if(idAvailable == 1)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT v.placa, v.veiculo, v.condutor, v.tipo, e.dt_entrada, e.dt_saida, " +
                        "CONCAT( DATEDIFF(HOUR, e.dt_entrada, e.dt_saida), 'h:', " +
                        "DATEPART(MINUTE, e.dt_entrada) - DATEPART(MINUTE, e.dt_saida), 'min:', DATEPART(SECOND, e.dt_saida) - DATEPART(SECOND, e.dt_entrada), 's' )" +
                        "AS diferenca_horas_minutos_segundos FROM estacionamento e INNER JOIN veiculos v on v.placa = e.fk_placa WHERE dt_entrada BETWEEN @dataInicial and @dataFinal and v.tipo = @tipoSelecionado", conn);
                    cmd.Parameters.AddWithValue("@dataInicial", dataInicial.ToString("yyyy-dd-MM HH:mm:ss.fff"));
                    cmd.Parameters.AddWithValue("@dataFinal", dataFinal.ToString("yyyy-dd-MM HH:mm:ss.fff"));
                    cmd.Parameters.AddWithValue("@tipoSelecionado", comboBox1.Text);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    da.Fill(dt);



                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].HeaderText = "Placa";
                    dataGridView1.Columns[1].HeaderText = "Veículo";
                    dataGridView1.Columns[2].HeaderText = "Condutor";
                    dataGridView1.Columns[3].HeaderText = "Tipo de Veiculo";
                    dataGridView1.Columns[4].HeaderText = "Data de Entrada";
                    dataGridView1.Columns[5].HeaderText = "Data de Saída";
                    dataGridView1.Columns[6].HeaderText = "Permanência do Veículo";
                    updateDados();
                    qtdAcessos++;
                    lblAcessos.Text = qtdAcessos.ToString();
                    idAvailable = 0;
                    conn.Close();
                }
                catch (Exception e2)
                {
                    MessageBox.Show("Ocorreu um erro ao listar. Motivo: " + e2.Message);
                }
            }
                  
    }

        public void conexao()
        {
            conn = new SqlConnection(@"Data Source=KERNELOS-PC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        }

        public void updateDados()
        {
            if(comboBox1.Text.Equals("Moto")) {
                retornarDados.setMoto();
                lblMoto.Text = retornarDados.getQtdMoto().ToString();
            } else if(comboBox1.Text.Equals("Carro"))
            {
                retornarDados.setCarro();
                lblCarro.Text = retornarDados.getQtdCarro().ToString();
            }       
        }
      
    }
}
