using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulado_02__com_consulta_
{

   
    public partial class FrmCadastroProduto : Form
    {
        private Produto produto;

        private List<Tipo> tipos = new List<Tipo>();

        private Tipo tipo;

        private retornarDados list;

        private SqlConnection sql;

        private FrmListagemTipoProduto listagemTipoProduto = new FrmListagemTipoProduto();

        private FrmListagemProduto listagemProduto = new FrmListagemProduto();
        public FrmCadastroProduto()
        {
            InitializeComponent();
            listagemTipoProduto.add();
            carregarCombo();
            con();
        }

        public void carregarCombo()
        {
            tipos = retornarDados.getTipos();
            cbTipo.Items.Clear();
            for (int i = 0; i < tipos.Count; i++)
            {
                cbTipo.Items.Add(tipos[i].Descricao);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String descricao = textBox1.Text;
                
                for (int i = 0; i < tipos.Count; i++)
                {
                    if (tipos[i].Descricao.Equals(cbTipo.Text))
                    {
                        tipo = new Tipo(tipos[i].Id, tipos[i].Descricao);
                    }
                }
                produto = new Produto(descricao, tipo);
                listagemProduto.add();
                sql.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO produtos values (@descricao, @fk_tipo)", sql);
                cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@fk_tipo", produto.TipoProduto.Id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto inserido com sucesso!");
            } catch(Exception e2)
            {
                MessageBox.Show("Ocorreu um erro ao inserir o produto. Motivo: " + e2.Message);
            } finally
            {
                sql.Close();
            }
        }

        public void con()
        {
            sql = new SqlConnection(@"Data Source=KERNELOS-PC\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        }
    }
}
