using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado03__Com_consulta_
{
    public class Veiculo
    {
        public String Placa { get; set; }

        public String NomeVeiculo { get; set; }
        public String Condutor { get; set; }

        public String TipoVeiculo { get; set; }

        public Veiculo(String placa, String nomeVeiculo, String condutor, String tipoVeiculo)
        {
            Placa = placa;
            NomeVeiculo = nomeVeiculo;
            Condutor = condutor;
            TipoVeiculo = tipoVeiculo;
        }

        public String toString()
        {
            return NomeVeiculo;
        }
    }
}
