using BDRedSocial.Data.Entity;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BDRedSocial
{
        public class DBcontext : DbContext
        {

            public DbSet<Trabajador> Trabajadores { get; set; }
            public DbSet<Publicacion> PuBlicaciones { get; set; }


            public DBcontext(DbContextOptions options) : base(options)
            {

            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            { }

            /*protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<CargoRed>(o =>
                {
                    o.HasKey(b => b.Id);
                    o.Property(b => b.CodCarRed);
                    o.Property(b => b.DescCargoRed);
                });
                modelBuilder.Entity<Trabajador>(o =>
                {
                    o.HasKey(b => b.Id);
                    o.Property(b => b.Nombre);
                    o.Property(b => b.Apellido);
                    o.Property(b => b.Puesto);
                    o.Property(b => b.Correo);
                    o.Property(b => b.Edad);
                });
                modelBuilder.Entity<Puesto>(o =>
                {
                    o.HasKey(b => b.Id);
                    o.Property(b => b.CodPuesto);
                    o.Property(b => b.Correo);
                    o.Property(b => b.Trabajador);

                });
            }*/
        }
    
}