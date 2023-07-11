using projetoLinq;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Medico> medicos = new List<Medico>();
        List<Procedimento> procedimentos = new List<Procedimento>();
        using (StreamReader dataMedicos = new StreamReader("dataMedicos.json"))
        {
            String json = dataMedicos.ReadToEnd();
            medicos = System.Text
                        .Json.JsonSerializer
                        .Deserialize<List<Medico>>(
                                json, new System.Text.Json.JsonSerializerOptions()
                                {
                                    PropertyNameCaseInsensitive = true
                                }

                        )!;
        }

        using (StreamReader dataProcedimentos = new StreamReader("dataProcedimientos.json"))
        {
            String json = dataProcedimentos.ReadToEnd();
            procedimentos = System.Text
                        .Json.JsonSerializer.Deserialize<List<Procedimento>>(
                                json, new System.Text.Json.JsonSerializerOptions()
                                {
                                    PropertyNameCaseInsensitive = true
                                }

                        )!;
        }

        /*

        Console.WriteLine("\t{0,25} {1}", "Nombre", "Identificación");
        */
        
        /*
        foreach (var medico in medicos)
        {
            
            Console.WriteLine("\t{0,25} {1,-14}", medico.Nombre, medico.Identificacion);
            
        }
         */
        

        //Execução Retardada

        // var listaMedicos = from m in medicos
        //             select m;

        // Lista.mostrarMedicos(listaMedicos);


        //var listaMedicoss = from m in medicos
        //                 where m.Edad == 18
        //                select m.Identificacion;

        //  Lista.mostrarMedicos(listaMedicoss);

        Medico meuMedico = new Medico();

        meuMedico.Nombre = "Johnn";
        meuMedico.Identificacion = "354789";
        meuMedico.Edad = 14;
        meuMedico.Procedimiento = 25;
        medicos.Add(meuMedico);



        var medicosHehe = from m in medicos
                          group m by m.Procedimiento into me
                          select new
                          {
                              Procedimento = me.Key,
                              Cantidad = me.Count()
                          };



        var medicosJoin = from m in medicos
                          join p in procedimentos on m.Procedimiento equals p.Id
                          select new
                          {
                              Medico = m.Nombre,
                              Identificacion = m.Identificacion,
                              Procedimento = p.Nombre
                          };

        var medicosHehes = from m in medicos
                          join p in procedimentos on m.Procedimiento equals p.Id
                          select new
                          {
                              Procedimento = p.Nombre
                          };

        var listaProcedimentos = from p in procedimentos
                                 join m in medicos on p.Id equals m.Procedimiento into me
                                 from m in me.DefaultIfEmpty()
                                 let medico = m == null ? "Sin medico" : m.Nombre
                                 let identificacion = m == null ? new String('-', 14) : m.Identificacion
                                 orderby medico
                                 select new
                                 {
                                     Medico = medico,
                                     Identificacion = identificacion,
                                     Procedimento = p.Nombre
                                 };



        Lista.mostrarMedicos(listaProcedimentos);
    }
}

    
