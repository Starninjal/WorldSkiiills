using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulado01__Sem_Consulta_
{
    public class ListMoeda
    {
        private static List<Conversao> Conversoes = new List<Conversao>();

        public static List<Conversao> add(Conversao conversao)
        {
            Conversoes.Add(conversao);
            return Conversoes;
        }

        public static List<Conversao> List()
        {
            return Conversoes;
        }

        public static void update(List<Conversao> conversoes)
        {

            Conversoes = conversoes;
        }

        public static void clear()
        {
            Conversoes.Clear();
        }

      
    }
}
