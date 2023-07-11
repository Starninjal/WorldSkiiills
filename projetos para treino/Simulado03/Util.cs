using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulado03
{
    public class Util
    {

        public void validarVeiculo(Veiculo veiculo)
        {
            if (veiculo == null)
            {
                throw new ArgumentNullException("Veiculo não deve estar vazio!");
            } else
            {
                if(veiculo.Placa == null)
                {
                    throw new ArgumentNullException("A placa não pode ser vazia!");
                }
                if(veiculo.NomeVeiculo == null)
                {
                    throw new ArgumentNullException("O nome do veículo não pode ser nulo!");
                }

                if(veiculo.Condutor == null)
                {
                    throw new ArgumentException("O nome do condutor não pode ser nulo!");
                }

                if(veiculo.Tipo == null)
                {
                    throw new ArgumentException("O tipo do veiculo não pode ser nulo!");
                }
            }

           
            
        }
    }
}
