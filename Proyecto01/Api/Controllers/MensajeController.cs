using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dominio;
using Modelo;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensajeController : Controller
    {
        // GET: /<controller>/  api/Mensajes

        // DELETE
        [HttpPost]
        public async Task<ActionResult<int>> Post(Mensajes mensajes)
        {
            boolean respuesta = false;
            //context.Add(Mensajes);
            Dominio.Mensaje ms = new Dominio.Mensaje();// AdicionarMensajes
            ms.EliminarMensajesUltimo(mensajes);


            //AdicionarMensajes
            //await context.SaveChangesAsync();
            return Convert.ToInt16( ms.EliminarMensajesUltimo(mensajes));
        }
    }
}

