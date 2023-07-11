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

namespace Simulado_02__com_consulta_
{
    public partial class FrmListagemProduto : Form
    {

        private Tipo tipo;

        private List<Tipo> tiposList = new List<Tipo>();

        private SqlConnection sql;
        public FrmListagemProduto()
        {
            InitializeComponent();
            con();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCadastroProduto frm = new FrmCadastroProduto();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand("SELECT p.id as idProduto, t.id as idTipo, p.descricao as ProdutoDescricao, t.descricao as TipoDescricao FROM produtos p, tipos t WHERE p.id_tipo = t.id", sql);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProduto.DataSource = dt;
                
            } catch(Exception e2)
            {
                sql.Close();
                MessageBox.Show("Ocorreu um erro ao listar os produtos. Motivo: " + e2.Message);
            }
         
        }

        public List<Produto> listarProdutos()
        {
            List<Produto> produtos = new List<Produto>();
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand("SELECT p.id, p.descricao, t.id, t.descricao FROM produtos p, tipos t WHERE p.id_tipo = t.id", sql);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        produtos.Add(extrairDo(reader));
                    }
                }
               
                
            } catch(Exception e)
            {
                sql.Close();
            }

            return produtos;
        }

        public List<Produto> listarProdutosTela()
        {
            List<Produto> produtos = new List<Produto>();
            try
            {
                sql.Open();
               
                SqlCommand cmd = new SqlCommand("SELECT p.id, p.descricao, t.id, t.descricao FROM produtos p, tipos t WHERE p.id_tipo = t.id", sql);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        produtos.Add(extrairDo(reader));
                    }
                }
                sql.Close();
                
            } catch(Exception e2)
            {
                sql.Close();
                MessageBox.Show(e2.Message);
            }

            return produtos;

        }

        public Produto extrairDo(SqlDataReader reader)
        
        {
            long idProduto = reader.GetInt64(0);
            String descricaoProduto= reader.GetString(1);
            long idTipo = reader.GetInt64(2);
            String descricaoTipo = reader.GetString(3);
            tipo = new Tipo(idTipo, descricaoTipo);
            return new Produto(idProduto, descricaoProduto, tipo);
        }

        public void con()
        {
            sql = new SqlConnection(@"Data Source=SN-386958\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        }

        public void add()
        {
            retornarDados.add(listarProdutosTela());
        }

      
   

 

  

    }

}
