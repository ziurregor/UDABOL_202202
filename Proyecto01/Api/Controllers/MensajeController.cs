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
        // GET: /<controller>/  api/usuarios
        [HttpGet]
        public IEnumerable<Modelo.Mensajes> Get() //IActionResult Index()
        {
            Mensaje mensaje = new Dominio.Mensaje();
            List<Modelo.Mensajes> lista = new List<Modelo.Mensajes>();
            //lista.Add(new Users { Usuario = "Regor", Name = "Roger Ruiz", IsActive = true, Edad = 47, Contraseña = "123456" });
            lista = mensaje.ListarMensajes();

            return lista;
        }

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


        [HttpDelete("{id}")]
        public Boolean DeleteMensajePorId (int id)
        {
            Dominio.Mensaje ms = new Dominio.Mensaje();

            Boolean encontrado = false;
            List<Mensajes> listMensajes = ms.ListarMensajes();
            for(int i = 0; i < listMensajes.Count; i++)
            {
                if(listMensajes[i].MensajeId == id)
                {
                    encontrado = true; //verificamos si mensaje existe
                }
            }
            if(encontrado){
                return ms.EliminarMensaje(id);  // eliminamos Mensaje por ID}
            }else{
                return false;
            }
        }
        //get http://localhost:PUER/api/Mensaje   ==devuelve la lista de Mensajes
        //get http://localhost:PUER/api/Usuario   ==devuelve la lista de usuarios
        //get http://localhost:PUER/api/Usuario/{Userid}   ==devuelve un usuario
    }
}

