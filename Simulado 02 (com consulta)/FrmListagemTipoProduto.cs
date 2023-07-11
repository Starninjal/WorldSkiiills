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
    public partial class FrmListagemTipoProduto : Form
    {

        private SqlConnection sql;

        private List<Tipo> listTipo = new List<Tipo>();

        private retornarDados list;
        
        public FrmListagemTipoProduto()
        {
            InitializeComponent();
            con();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCadastroTipoProduto frm = new FrmCadastroTipoProduto();
            frm.Show();
        }

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand("SELECT id, descricao from tipos", sql);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtTipo.DataSource = dt;
                MessageBox.Show("Dados Carregados com Sucesso!");

                sql.Close();
                
            }
            catch (Exception e2)
            {
                MessageBox.Show("Ocorreu um erro ao listar. Motivo: " + e2.Message);
            }
            


        }

        private List<Tipo> listar()
        {
            sql.Open();
            List<Tipo> tipos = new List<Tipo>();
            SqlCommand cmd = new SqlCommand("select id, descricao from tipos", sql);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    tipos.Add(extrairDo(reader));
                    
               }

                sql.Close();
            }
            
            return tipos;
        }

        public Tipo extrairDo(SqlDataReader reader)
        {
            try
            {
                long id = reader.GetInt64(0);
                String descricao = reader.GetString(1);
                return new Tipo(id, descricao);
            }
            catch (Exception e)
            {
                throw new Exception("Ocorreu um erro com ao extrair o tipo do dataReader. Motivo: " + e.Message);
            }

        }

        public void con()
        {
            sql = new SqlConnection(@"Data Source=KERNELOS-PC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        }

        public void add()
        {
            retornarDados.add(listar());
        }
    }

    


}
