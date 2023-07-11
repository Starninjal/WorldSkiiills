using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CambioSenai
{
    public class retornarDados
    {
       public static List<Conversao> Conversoes { get; set; } = new List<Conversao>();

       public static void adicionarConversao(Conversao conversoes)
        {
            Conversoes.Add(conversoes);
            
        }




        public static List<Conversao> listarConversao()
        { 
            return Conversoes;
        }
        


    }
}
