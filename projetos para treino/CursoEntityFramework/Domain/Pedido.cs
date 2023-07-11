using CursoEntityFramework.ValueObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEntityFramework.Domain
{
    public class Pedido
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }  

        public Cliente Cliente { get; set; }

        public DateTime IniciadoEm { get; set; }

        public DateTime FinalizadoEm { get; set; }

        public TipoFrete TipoFrete { get; set; }

        public StatusPedido Status { get; set; }

        public String Observacao { get; set; }

        public ICollection<PedidoItem> Itens { get; set; }  

        public DateTime FinalizadoEM { get; internal set; }

        public String Nome { get; internal set; }


    }
}
