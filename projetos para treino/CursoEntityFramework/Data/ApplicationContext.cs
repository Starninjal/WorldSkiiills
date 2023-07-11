using CursoEntityFramework.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoEntityFramework.Data
{
    public class ApplicationContext : DbContext
    {
        DbSet<Pedido> pedidos { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =SN-386958\SQLEXPRESS;Initial Catalog = master;Integrated Security =True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(p =>
            {
                p.ToTable("Cliente");
                p.HasKey(p => p.id);
                p.Property(p => p.Nome).HasColumnName("VARCHAR(80)").IsRequired();
                p.Property(p => p.Telefone).HasColumnName("CHAR(11)").IsRequired();
                p.Property(p => p.Cep).HasColumnName("CHAR(8)").IsRequired();
                p.Property(p => p.Estado).HasColumnName("CHAR(8)").IsRequired();
                p.Property(p => p.Cidade).HasMaxLength(60).IsRequired();

            //    p.HasIndex( => fk_telefone.Telefone).HasName("fk_telefone");

            });

            modelBuilder.Entity<Produto>(p => {
                p.ToTable("Produto");

                p.HasKey(p => p.Id);

                p.Property(p => p.CodigoBarra).HasColumnType("VARCHAR(80)").IsRequired();

                p.Property(p => p.Descricao).HasColumnType("CHAR(11)").IsRequired();

                p.Property(p => p.Valor).IsRequired();

                p.HasMany(p => p.Itens).WithOne(p => p.Pedido).OnDelete(DeleteBehavior.Cascade);


            });

            modelBuilder.Entity<Pedido>(p =>
            {
                p.ToTable("Pedido");

                p.HasKey(p => p.Id);

                p.Property(p => p.Status).HasConversion<String>();

                p.Property(p => p.TipoFrete).HasConversion<String>();

                p.Property(p => p.Observacao).HasColumnType("CHAR(502)").IsRequired();
            });

            modelBuilder.Entity<PedidoItem>(p =>
            {
                p.ToTable("PedidoItem");

                p.HasKey(p => p.Id);

                p.Property(p => p.Quantidade).HasDefaultValue(1).IsRequired();

                p.Property(p => p.Valor).IsRequired();

                p.Property(p => p.Desconto).IsRequired();
            });
        }
    }
}
