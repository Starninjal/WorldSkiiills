using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambioSenai
{
    public class ServiceBase
    {
        public void validarBase(Conversao conversao)
        {
            if(conversao != null)
            {
                Boolean isDescricaoInvalida = conversao.Moeda.Length > 30;
                if (isDescricaoInvalida)
                {
                    throw new Exception("A descrição da moeda deve ter 30 caracteres ou menos! Tente novamente!");
                }
                Boolean isBaseInvalida = conversao.BaseConversao < 0;
                if (isBaseInvalida)
                {
                    throw new Exception("A base de conversao não pode ser negativa");
                }

                if(isBaseInvalida && isDescricaoInvalida)
                {
                    throw new Exception("A base de conversão não pode ser negativa e a descrição não pode ultrapassar 30 caracteres. Tente novamente!");

                }

                if(isDescricaoInvalida.Equals(""))
                {
                    throw new Exception("Campo descrição vazio, insira algo e tente novamente!");
                }
                if(conversao.BaseConversao <= 0)
                {
                    throw new Exception("Campo base não pode estar vazia, insira seu conteúdo e tente novamente!");
                }
                
            } else
            {
                throw new Exception("A conversão não pode ser nula. Tente novamente!");
            }

            
        }
       
    }
}
