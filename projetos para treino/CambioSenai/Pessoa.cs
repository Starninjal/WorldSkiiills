using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambioSenai
{
    public class Pessoa
    {

        private int id = 0;

        private String nome;

        private String uf;

        public Pessoa(String nome, String uf)
        {
            id++;
            this.nome = nome;
            this.uf = uf;
        }

        public void validacaoDados()
        {
            if(this.uf.Length != 2)
            {
                this.uf = null;
                throw new Exception("A uf não pode ser diferente de 2 caracteres");
            } else if(this.nome.Length < 0)
            {
                this.nome = null;
                throw new Exception("O nome não pode ser nulo!");
            }
        }

        public String Nome { get; set; }

        public String UF { get; set; }

        public String toString() // precisa disso se não ele pega o endereço de memória então logo você precisa listar com o {nomeObjeto}[i].{nomeAtributo}
        {
            return this.nome;
        }
    }
}
