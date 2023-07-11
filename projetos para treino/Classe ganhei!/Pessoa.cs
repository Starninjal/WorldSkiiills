using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_ganhei_
{
    public class Pessoa
    {
        public int Id { get; set; }

        public String nome { get; set; }

        public String cpf { get; set; }

        public String sobrenome;

        public int res;

        public void nomeInteiro(String nome, string sobrenome)
        {
            MessageBox.Show("Meu nome é " + nome + " e meu sobrenome é " + sobrenome);
        }


        public int solucao(int v1, int v2, string op)
        {
            switch (op)
            {
                case "adição":
                     
            }

        }



    }
}
