using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.EntityClient;
using System.Data.Entity;
using Controller.Map;

namespace Controller.Controllers
{
    public class SistemaContext : DbContext
    {
        public SistemaContext() : base("Server=SN-386958\\SQLEXPRESS; Database=simulado03; Integrated Security=True;")

        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SistemaContext>(null);
            modelBuilder.Configurations.Add(new EstacionamentoMap());
            modelBuilder.Configurations.Add(new VeiculoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
