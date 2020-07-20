using BreadGiverApp.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreadGiverApp.Server.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class ProductoController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public ProductoController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<ActionResult<List<Producto>>> Get()
        {
            return await context.Productos.ToListAsync();
        }

        public async Task<ActionResult<int>> Post(Producto producto)
        {
            context.Add(producto);
            await context.SaveChangesAsync();
            return producto.Id;
        }
    }
}
