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
    public partial class FrmCadastroTipoProduto : Form
    {
        private SqlConnection sql;

        private Tipo tipo;
        public FrmCadastroTipoProduto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String descricao = textBox1.Text;

                tipo = new Tipo(descricao);

                if (tipo.Descricao.Equals("")) 
                {
                    throw new Exception("A descrição não pode ser vazia. Preencha ele e tente novamente a inserção!");
                }
                else
                {
                    sql = new SqlConnection(@"Data Source=SN-386958\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
                    sql.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tipos VALUES (@descricao)", sql);
                    cmd.Parameters.AddWithValue("@descricao", tipo.Descricao);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tipo Cadastrado com sucesso!");
                }
            } catch(Exception e2)
            {
                MessageBox.Show("Ocorreu um erro ao inserir. Motivo: " + e2.Message);
            } finally
            {
                sql.Close();
            }
            
        }
    }
}
