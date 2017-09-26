using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace outGo.Models
{
    public partial class outGoContext : DbContext
    {
        /*public outGoContext(DbContextOptions<outGoContext> options)
            : base(options)
        {
        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(local);Database=outGo;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");

            #region Table Definition
                modelBuilder.Entity<Facturas>()
                    .ToTable(@"Facturas", @"dbo")
                    .HasKey(c => c.Id);

                modelBuilder.Entity<Detalles>()
                    .ToTable(@"Detalles", @"dbo")
                    .HasKey(c => new { c.IdFactura, c.TipoGasto });

                modelBuilder.Entity<Comercios>()
                    .ToTable(@"Comercios", @"dbo")
                    .HasKey(c => c.Id);

                modelBuilder.Entity<Personas>()
                    .ToTable(@"Personas", @"dbo")
                    .HasKey(c => c.Id);

                modelBuilder.Entity<Relaciones>()
                    .ToTable(@"Relaciones", @"dbo")
                    .HasKey(c => c.Id);

                modelBuilder.Entity<Pagos>()
                    .ToTable(@"Pagos", @"dbo")
                    .HasKey(c => c.Id);
            #endregion

            #region Property
                modelBuilder.Entity<Comercios>().Property(b => b.TipoComercio).HasDefaultValue("Supermercado");
                modelBuilder.Entity<Facturas>().Property(b => b.Fecha).HasDefaultValueSql("getdate()");
                modelBuilder.Entity<Pagos>().Property(b => b.Fecha).HasDefaultValueSql("getdate()");
                modelBuilder.Entity<Detalles>().Property(b => b.TipoGasto).HasDefaultValue("Comida");                
            #endregion


            #region Relationship
            modelBuilder.Entity<Comercios>()
                    .HasMany(x => x.Facturas)
                    .WithOne(op => op.Comercios)
                    .IsRequired(true)
                    .HasForeignKey(@"IdComercio");

                modelBuilder.Entity<Detalles>()
                    .HasOne(x => x.Facturas)
                    .WithMany(op => op.Detalles)
                    .IsRequired(true)
                    .HasForeignKey(@"IdFactura");

                modelBuilder.Entity<Facturas>()
                    .HasMany(x => x.Detalles)
                    .WithOne(op => op.Facturas)
                    .IsRequired(true)
                    .HasForeignKey(@"IdFactura");

                modelBuilder.Entity<Facturas>()
                    .HasOne(x => x.Comercios)
                    .WithMany(op => op.Facturas)
                    .IsRequired(true)
                    .HasForeignKey(@"IdComercio");
            #endregion     
        }


        public virtual DbSet<Comercios> Comercios { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
        public virtual DbSet<Relaciones> Relaciones { get; set; }
        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<Detalles> Detalles { get; set; }
    }
}
