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
        public int Post(Modelo.Mensajes mensajes)
        //Task<ActionResult<int>> Post(Modelo.Mensajes mensajes)
        {
            // Boolean respuesta = false;

            Dominio.Mensaje ms = new Dominio.Mensaje();// AdicionarMensajes

            var a = ms.EliminarMensajesUltimo(mensajes);

            return 1;//ver como devolver OK
        }
        //get http://localhost:PUER/api/Mensaje   ==devuelve la lista de Mensajes
        //get http://localhost:PUER/api/Usuario   ==devuelve la lista de usuarios
        //get http://localhost:PUER/api/Usuario/{Userid}   ==devuelve un usuario
    }
}
