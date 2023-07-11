using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllerss.Context
{
    public class SistemaContext : DbContext
    {
        public SistemaContext() : base(@"Server= SN-386958\\SQLEXPRESS; Database= simulado03; Integrated Security=;")
        {
            
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer<SistemaContext>(null);
            modelBuilder.Configurations.Add(new VeiculoMap());
            modelBuilder.Configurations.Add(new EstacionamentoMap());
        }
    }
}
