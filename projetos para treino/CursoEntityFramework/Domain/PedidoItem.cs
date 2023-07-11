using CursoEntityFramework.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CursoEntityFramework.Domain
{
    public class PedidoItem
    {
        public int Id { get; set; }

        public int PedidoId { get; set; }

        public Pedido Pedido { get; set; }  

        public Produto Produto { get; set; }

        public int Quantidade { get; set; }

        public double Desconto { get; set; }

        public double Valor { get; set; }

        public object ProdutoId { get; set; }
    }
}
