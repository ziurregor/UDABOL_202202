using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo;
using System.Collections.Generic;
using System.Linq;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Mensajes2Controller : ControllerBase
    {
        private DBCtx Context { get; }

        public Mensajes2Controller(DBCtx _context)
        {
            this.Context = _context;
        }


        [Route("GetMensajec")]
        [HttpGet]
        public List<Mensajes> GetMensajec(string name)
        {
            return (from c in this.Context.Mensajec.Take(10)
                    where c.Mensaje.StartsWith(name) || string.IsNullOrEmpty(name)
                    select c).ToList();
        }
    }
}
