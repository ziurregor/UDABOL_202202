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
    public class UsuarioController : Controller
    {
        // GET: /<controller>/  api/usuarios
        [HttpGet]
        public IEnumerable<Users> Get() //IActionResult Index()
        {
            Usuario user = new Dominio.Usuario();
            List<Users> lista = new List<Users>();
            //lista.Add(new Users { Usuario = "Regor", Name = "Roger Ruiz", IsActive = true, Edad = 47, Contraseña = "123456" });
            lista = user.ListarUsuarios();

            return lista;
        }

        [HttpPost]
        public int Post(Modelo.Users usuarios)
        //Task<ActionResult<int>> Post(Modelo.Usuarios usuarios)
        {
            // Boolean respuesta = false;
            Dominio.Usuario ms = new Dominio.Usuario();// AdicionarUsuarios
            var a = ms.EliminarUsuarioPorUserId(usuarios.UserId);
            return 1;//ver como devolver OK
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Boolean DeleteUsuarioPorId (int id)
        {
            Dominio.Usuario ms = new Dominio.Usuario();
            Modelo.Users usuario = ms.UsuarioPorUserId(id);
            if(usuario==null)                                       //verificamos si el usuario existe
                return false;
            var a = ms.EliminarUsuarioPorUserId(id);   // eliminamos Usuario por ID
            return true;
        }

        //[HttpPut("{id:int}")]
        //public async Task<ActionResult> Put(int id, Mensajes mensajes)
        //{
        //    Console.WriteLine("modificar");
        //    var mesnajesExiste = await MensajesExiste(id);
        //    Console.WriteLine("mensaje no existente: " + MensajesExiste);

        //    if (!MesajesExiste)
        //    {
        //        return NotFound();
        //    }

        //    context.Update(Mensajes);
        //    await context.SaveChangesAsync();
        //    return NoContent();
        //}
    }
}

