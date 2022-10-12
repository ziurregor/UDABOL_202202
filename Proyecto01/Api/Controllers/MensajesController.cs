using Dominio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo;
using System.Collections.Generic;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensajesController : ControllerBase
    {
        /*[HttpGet]
        public IEnumerable<Mensajes> Get() 
        {
            Mensaje messagge = new Dominio.Mensaje();
            List<Mensajes> lista = new List<Mensajes>();
            lista.Add(new Mensajes { UseridId = 2, Mensaje = "Hola bienvenidos"});
            lista = messagge.ListarMensajes();

            return (List<Mensajes>)messagge.ListarMensajes();

        }*/
    }
}
