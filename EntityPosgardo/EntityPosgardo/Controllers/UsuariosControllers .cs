using EntityPosgardo.infraestructura;
using EntityPosgardo.modelo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityPosgardo.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuariosControllers : ControllerBase
    {
        private readonly InfraestructuraDbContext context;

        public UsuariosControllers(InfraestructuraDbContext context)
        {
            this.context = context;
        }

        [HttpGet("get")]
        public async Task<IEnumerable<Usuarios>> Get()
        {
            return await context.usuario.ToListAsync();
        }

        [HttpPost("post")]
        public async Task<ActionResult> Post(Usuarios user)
        {
            context.Add(user);
            await context.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("delete/{id:int}")]
        public async Task<ActionResult> delete(int id)
        {
            var usuarios = await context.usuario.FirstOrDefaultAsync(r => r.UsuariosId == id);
            if (usuarios is null)
            {
                return NotFound();
            }
            context.Remove(usuarios);
            await context.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("desconectar/{id:int}")]
        public async Task<ActionResult> desconectar(int id)
        {
            var usuarios = await context.usuario.AsTracking().FirstOrDefaultAsync(r => r.UsuariosId == id);
            if (usuarios is null)
            {
                return NotFound();
            }
            usuarios.estado = true;
            await context.SaveChangesAsync();
            return Ok();

        }
    }
}
