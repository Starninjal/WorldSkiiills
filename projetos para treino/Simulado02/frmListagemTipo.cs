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

namespace Simulado02
{
    public partial class frmListagemTipo : Form
    {
        public frmListagemTipo()
        {
            InitializeComponent();
            conexao = new Conexao();
        }

        private Conexao conexao;

        

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCadastrarTipo frmCadastrarTipo = new frmCadastrarTipo();
            frmCadastrarTipo.Show();
        }

        private void button1_Click(object sender, EventArgs e)   
        {

            String formatar =  txtFiltro.Text + "%";

            SqlCommand cmd = new SqlCommand("SELECT" +
                "                               *" +
                "                           FROM" +
                "                               tipos" +
                "                           WHERE Upper(descricao) LIKE Upper(@filtro)");

            cmd.Parameters.AddWithValue("@filtro", formatar);
            cmd.Connection = conexao.conectar();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conexao.desconectar();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tipos ");


            cmd.Connection = conexao.conectar();

            SqlDataReader dataReader = cmd.ExecuteReader();

            while(dataReader.Read())
            {
            }
                

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
            SqlCommand cmd = new SqlCommand("DELETE tipos where id =  '" +id+"'");

            cmd.Connection = conexao.conectar();

            cmd.ExecuteNonQuery();

            bindGrid();

            conexao.desconectar();
        }

        public void bindGrid()
        {
            SqlCommand cmd = new SqlCommand("select * from tipos");

            cmd.Connection = this.conexao.conectar();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;



            
        }
    }
}
