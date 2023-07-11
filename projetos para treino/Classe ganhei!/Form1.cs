using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_ganhei_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.nome = "João";
            pessoa.cpf = "123-2138529-24";

            lblNome.Text = pessoa.nome;
            lblCpf.Text= pessoa.cpf;

            pessoa.sobrenome = "Menezes";

            pessoa.nomeInteiro();

        }

       public void hehe(Pessoa pessoa)
        {

        }
        

    }

    
}
