using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado01__Sem_Consulta_
{
    public class Conversao
    {
        public String nomeMoeda { get; set; }

        public Double valorMoeda { get; set; }

        public Conversao(string nomeMoeda, double valorMoeda)
        {
            this.nomeMoeda = nomeMoeda;
            this.valorMoeda = valorMoeda;
        }

        public String toString()
        {
            return nomeMoeda;
        }
    }
}
