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
            return await context.Usuarios.ToListAsync();
        }

        [HttpPost("post")]
        public async Task<ActionResult> Post(Usuarios user)
        {
            context.Add(user);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> update(Usuarios request)
        {
            var user = await context.Usuarios.FirstOrDefaultAsync(r => r.UserId == request.UserId);

            if (user == null)
                return BadRequest("Usuario no encontrado");
            
            user.Usuario = request.Usuario;
            user.Name = request.Name;
            user.Edad= request.Edad;
            user.Contraseña = request.Contraseña;
            context.Update(user);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("delete/{id:int}")]
        public async Task<ActionResult> delete(int id)
        {
            var usuarios = await context.Usuarios.FirstOrDefaultAsync(r => r.UserId == id);
            if (usuarios is null)
            {
                return NotFound();
            }
            context.Remove(usuarios);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
