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
            return await context.Mensajes.ToListAsync();
        }

        [HttpPost("post")]
        public async Task<ActionResult> Post(Mensajes mensaje)
        {
            context.Add(mensaje);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> update(Mensajes request)
        {
            var mensaje = await context.Mensajes.FirstOrDefaultAsync(r => r.MensajeId== request.MensajeId);

            mensaje.Mensaje = request.Mensaje;
            context.Update(mensaje);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("delete/{id:int}")]
        public async Task<ActionResult> delete(int id)
        {
            var mensaje = await context.Mensajes.FirstOrDefaultAsync(r => r.MensajeId == id);
            if (mensaje is null)
            {
                return NotFound();
            }
            context.Remove(mensaje);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
