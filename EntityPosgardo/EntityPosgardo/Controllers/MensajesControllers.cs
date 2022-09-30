using EntityPosgardo.infraestructura;
using EntityPosgardo.modelo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityPosgardo.Controllers
{
    [ApiController]
    [Route("api/mensajes")]
    public class MensajesControllers : ControllerBase
    {
        private readonly InfraestructuraDbContext context;

        public MensajesControllers(InfraestructuraDbContext context)
        {
            this.context = context;
        }

        [HttpGet("get")]
        public async Task<IEnumerable<Mensajes>> Get()
        {
            return await context.Mensaje.ToListAsync();
        }

        [HttpPost("post")]
        public async Task<ActionResult> Post(Mensajes mensaje)
        {
            context.Add(mensaje);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("delete/{id:int}")]
        public async Task<ActionResult> delete(int id)
        {
            var mensaje = await context.Mensaje.FirstOrDefaultAsync(r => r.MensajeId == id);
            if (mensaje is null)
            {
                return NotFound();
            }
            context.Remove(mensaje);
            await context.SaveChangesAsync();
            return Ok();
        }
        [HttpDelete("desconectar/{id:int}")]
        public async Task<ActionResult> desconectar(int id)
        {
            var mensaje= await context.Mensaje.AsTracking().FirstOrDefaultAsync(m => m.MensajeId == id);
            if (mensaje is null)
            {
                return NotFound();
            }
            mensaje.estado = true;
            await context.SaveChangesAsync();
            return Ok();

        }
    }
}
