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
            int IdDelete = Convert.ToInt32(dtTipo.Rows[e.RowIndex].Cells[2].Value.ToString());

            if (dtTipo.Columns[e.ColumnIndex].Name == "Remover")
            {
                DialogResult dialogResult = MessageBox.Show("Confirmar Remoção", "Você realmente deseja remover a linha selecionada", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    removeData(IdDelete);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
         {
            displayData();
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
            sql = new SqlConnection(@"Data Source=SN-386958\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        }

        public void add()
        {
            retornarDados.add(listar());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Editar.Text = "haha";
        }

        private void dtTipo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int IdDelete = Convert.ToInt32(dtTipo.Rows[e.RowIndex].Cells[2].Value.ToString());
            DialogResult dialogResult = MessageBox.Show("Confirmar Remoção", "Você realmente deseja remover a linha selecionada", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                removeData(IdDelete);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        public void removeData(int idDelete)
        {
            try
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand("DELETE tipos where id = @id", sql);
                cmd.Parameters.AddWithValue("@id", idDelete);
                cmd.ExecuteNonQuery();
                sql.Close();
            } catch(Exception e)
            {
                MessageBox.Show("Impossível de deletar registro um ou mais produtos vinculados a ele.");
            }


        }

        public void displayData()
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

        
    }

    


}
