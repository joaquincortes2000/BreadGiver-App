using BreadGiverApp.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
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
            return await context.Producto.ToListAsync();
        }

        public async Task<ActionResult<int>> Post(Producto producto)
        {
            context.Add(producto);
            await context.SaveChangesAsync();
            return producto.Id;
        }
    }
}
