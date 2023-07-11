using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado_02__com_consulta_
{
    public class retornarDados
    {

        private static List<Produto> Produtos = new List<Produto>();

        private static List<Tipo> Tipos = new List<Tipo>();
        public static void add(List<Produto> produtos)
        {
            Produtos = produtos;
        }

        public static List<Produto> getProdutos()
        {
            return Produtos;
        }

        public static void add(List<Tipo> tipos)
        {
            Tipos = tipos;
        }

        public static List<Tipo> getTipos()
        {
            return Tipos;
        }


    }
}
