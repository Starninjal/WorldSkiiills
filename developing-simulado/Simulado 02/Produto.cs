using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado_02__com_consulta_
{
    public class Produto
    {
        public long Id { get; set; }

        public String Descricao { get; set; }

        public Tipo TipoProduto { get; set; }

        public Produto(long id, String descricao, Tipo tipoProduto)
        {
            Id = id;
            Descricao = descricao;
            TipoProduto = tipoProduto;
        }

        public Produto(String descrcao, Tipo tipoProduto)
        {
            Descricao  = descrcao;
            TipoProduto = tipoProduto;
        } 
      
    }
}
