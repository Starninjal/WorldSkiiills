using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado03__Com_consulta_
{
    public class Estacionamento
    {
        private long Id;

        private DateTime DataEntrada;

        private DateTime DataSaida;

        private Veiculo Veiculo;

        public Estacionamento(long id, DateTime dataEntrada, DateTime dataSaida, Veiculo veiculo)
        {
            this.Id = id;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
            this.Veiculo = veiculo;
        }


    }
}
