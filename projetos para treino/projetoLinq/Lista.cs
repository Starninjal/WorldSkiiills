using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLinq
{
    internal class Lista
    {
        public static string obterTexto(String option, String texto)
        {
            switch (option)
            {
                case "Nombre":
                    return String.Format("{0,-25}", texto);
                    break;
                case "Identificacion":
                    return String.Format(" {0,-14}", texto);
                    break;
                case "Edad":
                    return String.Format(" {0,-4}", texto);

                case "Procedimiento":
                    return String.Format(" {0,-14}", texto);

                case "Id":
                    return string.Format("{0, -4}", texto);
                case "Cantidad":
                    return String.Format(" {0, -4}", texto);
                case "Medico":
                    return String.Format(" {0, -25}", texto);
                case "Procedimento":
                    return String.Format(" {0, -4}", texto);
            }
            return "";
        }

        public static void mostrarMedicos(IEnumerable<dynamic> medicos)
        {
            if(medicos.Count() == 0)
            {
                Console.WriteLine("\n\tSin registros.");
                return;
            }

            var propriedades = medicos.First().GetType().GetProperties();
            String encabecado = "\n\t";
            foreach(var propriedade in propriedades)
            {
                encabecado += obterTexto(propriedade.Name, propriedade.Name);
            }

            Console.WriteLine(encabecado);

            int lenEncabecado = encabecado.Length;

            Console.WriteLine("\n\t {0}", new string('-', lenEncabecado));

            foreach (var medico in medicos)
            {
                String fila = "\n\t";
                foreach (var propriedade in propriedades)
                {
                    fila += obterTexto(propriedade.Name, propriedade.GetValue(medico).ToString());
                }

                Console.WriteLine(fila);
            }
            {

            }

        }
    }
}
