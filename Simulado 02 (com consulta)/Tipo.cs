using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado_02__com_consulta_
{
    public class Tipo
    {
        public long Id { get; set; }

        public String Descricao { get; set; }

        public Tipo(long id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public Tipo(String descricao)
        {
            Descricao = descricao;
        }
    }
}
