using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado03
{
    public class Estacionamento
    {
        public int Id { get; set; } 


        public DateTime Data_entrada { get; set; }

        public DateTime Data_saida { get; set; }

        public Veiculo Veiculo { get; set; }

        public Estacionamento(DateTime data_entrada, DateTime data_saida, Veiculo veiculo)
        {
            this.Data_entrada = data_entrada;
            this.Veiculo = veiculo;
            this.Data_saida = data_saida;
        }
    
    }
}
