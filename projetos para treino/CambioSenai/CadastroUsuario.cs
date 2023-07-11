using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CambioSenai
{
    public partial class CadastroUsuario : Form
    {

        private List<Pessoa> pessoas;

        private Pessoa pessoa;
        public CadastroUsuario()
        {
            InitializeComponent();
            this.pessoas = new List<Pessoa>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String nome = textBox1.Text;
                String uf = textBox2.Text;

                pessoa = new Pessoa(nome, uf);

                pessoas.Add(pessoa);

                for (int i = 0; i < pessoas.Count; i++)
                {
                    MessageBox.Show(pessoas[i].toString());
                }

                
            } catch(Exception e2) {
                throw new Exception("Ocorreu um erro ao salvar a pessoa. Motivo: " + e2.Message);
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pessoas.Count; i++)
            {
                comboBox1.Items.Add(pessoas[i].toString());

                

                
                
                if (pessoas[i].toString().Equals(textBox3.Text)) {
                    String hehe = comboBox1.SelectedItem.ToString();
                    MessageBox.Show(hehe);
                    MessageBox.Show(pessoas[i].toString() + " está logado");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mostrarNome mostrar = new mostrarNome(pessoas);
            mostrar.Show();
        }
    }
}
