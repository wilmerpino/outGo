using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace outGo.Models
{
    public partial class outGoEntities : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(local);Database=outGo;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");

            #region Table Definition
                modelBuilder.Entity<Facturas>()
                    .ToTable(@"facturas", @"dbo")
                    .HasKey(c => c.id);

                modelBuilder.Entity<Detalles>()
                    .ToTable(@"detalles", @"dbo")
                    .HasKey(c => new { c.id_factura, c.tipo_gasto });

                modelBuilder.Entity<Comercios>()
                    .ToTable(@"comercios", @"dbo")
                    .HasKey(c => c.id);

                modelBuilder.Entity<Personas>()
                    .ToTable(@"personas", @"dbo")
                    .HasKey(c => c.id);

                modelBuilder.Entity<Relaciones>()
                    .ToTable(@"relaciones", @"dbo")
                    .HasKey(c => c.id);

                modelBuilder.Entity<Pagos>()
                    .ToTable(@"pagos", @"dbo")
                    .HasKey(c => c.id);
            #endregion

            #region Property
                modelBuilder.Entity<Comercios>().Property(b => b.tipo).HasDefaultValue("Supermercado");
                modelBuilder.Entity<Facturas>().Property(b => b.fecha).HasDefaultValueSql("getdate()");
                modelBuilder.Entity<Pagos>().Property(b => b.fecha).HasDefaultValueSql("getdate()");
                modelBuilder.Entity<Detalles>().Property(b => b.tipo_gasto).HasDefaultValue("Comida");                
            #endregion


            #region Relationship
            modelBuilder.Entity<Comercios>()
                    .HasMany(x => x.facturas)
                    .WithOne(op => op.comercios)
                    .IsRequired(true)
                    .HasForeignKey(@"id_comercio");

                modelBuilder.Entity<Detalles>()
                    .HasOne(x => x.facturas)
                    .WithMany(op => op.detalles)
                    .IsRequired(true)
                    .HasForeignKey(@"id_factura");

                modelBuilder.Entity<Facturas>()
                    .HasMany(x => x.detalles)
                    .WithOne(op => op.facturas)
                    .IsRequired(true)
                    .HasForeignKey(@"id_factura");

                modelBuilder.Entity<Facturas>()
                    .HasOne(x => x.comercios)
                    .WithMany(op => op.facturas)
                    .IsRequired(true)
                    .HasForeignKey(@"id_comercio");
            #endregion     
        }


        public virtual DbSet<Comercios> comercios { get; set; }
        public virtual DbSet<Facturas> facturas { get; set; }
        public virtual DbSet<Pagos> pagos { get; set; }
        public virtual DbSet<Relaciones> relaciones { get; set; }
        public virtual DbSet<Personas> personas { get; set; }
        public virtual DbSet<Detalles> detalles { get; set; }
    }
}
