using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Simulado03__Com_consulta_
{
    public class retornarDados
    {

        public static List<Veiculo> Veiculos = new List<Veiculo>();
        public static void addVeiculo(List<Veiculo> veiculos)
        {
            Veiculos = veiculos; 
        }

        public static List<Veiculo> getVeiculos()
        {
            return Veiculos;
        }
    }
}
