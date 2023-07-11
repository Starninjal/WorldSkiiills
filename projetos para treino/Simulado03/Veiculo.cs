using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado03
{

    public class Veiculo
    {
        public int id;
        public String Placa { get; set; }

        public String NomeVeiculo { get; set; }

        public String Condutor { get; set; }

        public String Tipo { get; set; }


        public Veiculo(String placa, String nomeVeiculo, String condutor, String tipo) 
        {
            this.Placa = placa;
            this.NomeVeiculo = nomeVeiculo; 
            this.Condutor = condutor;
            this.Tipo = tipo;
        }

    }
}
