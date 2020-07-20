using BreadGiverApp.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<CarroCompra> CarroCompra { get; set; }
        public DbSet<Cotizacion> Cotizaciones { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<MetodoPago> MetodoPago { get; set; }
        public DbSet<Producto> Productos { get; set;  }

        public static implicit operator ControllerContext(ApplicationDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}
