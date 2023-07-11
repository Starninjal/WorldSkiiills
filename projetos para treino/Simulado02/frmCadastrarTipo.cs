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
    public partial class frmCadastrarTipo : Form
    {
        


        private Conexao conexao;

        private Tipo tipo;
        public frmCadastrarTipo()
        {
            InitializeComponent();
            conexao = new Conexao();
        }

        private void frmCadastrarTipo_Load(object sender, EventArgs e)
        {

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            frmListagemTipo frmListagem = new frmListagemTipo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                String descricao = textBox1.Text;

                


                tipo = new Tipo(descricao);

                cmd.CommandText = "INSERT INTO tipos(descricao) values(@descricao)";

                cmd.Parameters.AddWithValue("@descricao", tipo.Descricao);

                cmd.Connection = conexao.conectar();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Tipo de produto inserido com sucesso!")
               ;

            } catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao inserir o tipo de produto. Motivo: " + ex.Message);
            }
        }
    }
}
