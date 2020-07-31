using BreadGiverApp.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BreadGiverApp.Server.Controllers
{
    [ApiController]
    [Route("producto")]
    public class ProductoController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public ProductoController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [Route("obtenerTodos")]
        public async Task<ActionResult<List<Producto>>> Get()
        {
            return await context.Producto.ToListAsync();
        }

        [Route("registrar")]
        public async Task<ActionResult<int>> Post(Producto producto)
        {
            context.Add(producto);
            await context.SaveChangesAsync();
            return producto.Id;
        }

       
    }
}
