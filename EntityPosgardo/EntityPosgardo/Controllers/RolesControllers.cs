using EntityPosgardo.infraestructura;
using EntityPosgardo.modelo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityPosgardo.Controllers
{
    [ApiController]
    [Route("api/roles")]
    public class RolesControllers : ControllerBase
    {
        private readonly InfraestructuraDbContext context;

        public RolesControllers(InfraestructuraDbContext context)
        {
            this.context = context;
        }

        [HttpGet("get")]
        public async Task<IEnumerable<Roles>> Get()
        {
            return await context.Cargo.ToListAsync();
        }

        [HttpPost("post")]
        public async Task<ActionResult> Post(Roles roles)
        {
            context.Add(roles);
            await context.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("delete/{id:int}")]
        public async Task<ActionResult> delete(int id)
        {
            var roles = await context.Cargo.FirstOrDefaultAsync(r => r.RolesId == id);
            if (roles is null)
            {
                return NotFound();
            }
            context.Remove(roles);
            await context.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("desconectar/{id:int}")]
        public async Task<ActionResult> desconectar(int id)
        {
            var roles = await context.Cargo.AsTracking().FirstOrDefaultAsync(r => r.RolesId == id);
            if (roles is null)
            {
                return NotFound();
            }
            roles.estado = true;
            await context.SaveChangesAsync();
            return Ok();

        }
    }
}
