using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulado02
{
    public partial class frmCadastrarProduto : Form
    {
        private Conexao conexao;

        private Produto produto;

        private Tipo tipo;

        private Tipo tipo2;

        List<Tipo> tipos = new List<Tipo>();



        public frmCadastrarProduto()
        {
            InitializeComponent();
            cbTipo.SelectedText = tipos.Count.ToString();
            conexao =new Conexao();
            setarCombo(retornarDados());
            
        }

        

        

        private void txtSelecionar_Click(object sender, EventArgs e)
        {
            frmListagemTipo frmListagem = new frmListagemTipo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            MessageBox.Show("porra");
            try
             {
                String descricao = txtDescricao.Text;

                //Tipo tipo = (Tipo) cbTipo.Text;
                
                produto = new Produto(descricao, tipo2);

                try
                 {
                    cmd.CommandText = "insert into produtos (descricao, id_tipo) values (@descricao, @id_tipo)";

                    cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                    MessageBox.Show(produto.Descricao);

                    cmd.Parameters.AddWithValue("@id_tipo", validarDados());

                    cmd.Connection = conexao.conectar();

                    cmd.ExecuteNonQuery();

                    conexao.desconectar();

                    MessageBox.Show("Cadastrado com sucesso!");
                }
                catch (SqlException e2)
                {
                    MessageBox.Show("Ocorreu um erro ao inserir o produto. Motivo: " + e2.Message);
                }
                
                
            }
            catch (Exception e3)
            {
                MessageBox.Show("Ocorreu um erro também fdp. Motivo: " + e3.Message);

              }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public  List<Tipo> retornarDados()
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conexao.conectar();

            cmd.CommandText = "select id, descricao from tipos";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Tipo tipo = new Tipo(Convert.ToInt16(dr["id"].ToString()), dr["descricao"].ToString());
                tipos.Add(tipo);

            }
            conexao.desconectar();
            return tipos;

           

        }

        public int setarCombo(List<Tipo> tipos)
        {
            int id = 0;
            for (int i = 0; i < tipos.Count; i++)
            {
          
                    cbTipo.Items.Add(tipos[i].Descricao);
  
            }
            return id;
        }

        public int validarDados()
        {
            int id = 0;

            if (cbTipo.SelectedItem == null)
            {
                MessageBox.Show("O combo box não pode ser nulo!");

            }

            for (int i = 0; i < tipos.Count; i++)
            {
                if (cbTipo.SelectedItem.Equals(tipos[i].Descricao))
                {
                    
                    id = tipos[i].ID;

                    tipo2 = new Tipo(id, tipos[i].Descricao);

                    MessageBox.Show(id.ToString());

                }
            }

            return id;

            
        }
    }
}
