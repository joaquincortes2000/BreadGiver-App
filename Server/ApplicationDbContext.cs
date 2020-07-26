using BreadGiverApp.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace BreadGiverApp.Server
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<CarroCompra> CarroCompra { get; set; }
        public DbSet<Cotizacion> Cotizacion { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<MetodoPago> MetodoPago { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<CarroCompra_has_Producto> CarroCompra_Has_Producto { get; set; }
        public DbSet<Cotizacion_has_Producto> Cotizacion_Has_Producto { get; set; }
    }
}
