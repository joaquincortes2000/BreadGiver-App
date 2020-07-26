using BreadGiverApp.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BreadGiverApp.Server.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class UsuarioController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public UsuarioController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<ActionResult<List<Usuario>>> Get()
        {
            return await context.Usuario.ToListAsync();
        }
    }
}
