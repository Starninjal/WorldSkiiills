using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo
{
    public class Conversao
    {
        private int id;

        public Conversao(double baseConversao, string moeda)
        {
            BaseConversao = baseConversao;
            Moeda = moeda;
        }

        public String Moeda { get; set; }
        private Double BaseConversao { get; set; } 

       public String toString()
        {
            return Moeda;
        }
    }
}
