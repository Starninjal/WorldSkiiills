using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado02
{
    public class Tipo
    {

        private int id;

        private String descricao;

        public Tipo(String descricao) {
            Descricao = descricao;
        }

        public Tipo(int id, String descricao)
        {
            ID = id;
            Descricao = descricao;
        }

        public String Descricao { get; set; }

        public int ID { get;set; }

        public String toString()
        {
            return descricao;
        }

        public static implicit operator Tipo(int v)
        {
            throw new NotImplementedException();
        }
    }
}
