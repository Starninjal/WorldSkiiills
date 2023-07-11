using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllerss.Map
{
    public class EstacionamentoMap :EntityTypeConfiguration<Estacionamento>
    {
        public EstacionamentoMap()
        {
            this.ToTable("estacionamento");
            this.HasKey(e => e.Id);
            this.Property(e => e.Nome).HasColumnName("NOME_ESTACIONAMENTO");
        }
    }
}
