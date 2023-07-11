using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado02
{
    public class Produto
    {

        private int id;

        private String descricao;

        private Tipo tipo;

        public Produto(String descricao, Tipo tipo)
        {
            Descricao = descricao;
            Tipo = tipo;
            
        }
        public String Descricao { get; set; }

        public int ID { get; set; }

        public String toString()
        {
            return Descricao;
        }

        public Tipo Tipo { get; set; }
        
        }

    }

