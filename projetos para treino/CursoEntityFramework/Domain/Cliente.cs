using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CursoEntityFramework.ValueObject;

namespace CursoEntityFramework.Domain
{
    public class Cliente
    {
        public int id { get; set; }

        public String CodigoBarra { get; set; }    

        public String Descricao { get; set; }

        public decimal Valor { get; set; }

        public TipoProduto TipoProduto { get; set; }

        public String Nome { get; set; }

        public decimal Telefone { get; set;}

        public decimal Cep { get; set; }

        public String Cidade { get; set; }

        public String Estado { get; set; }




    }
}
