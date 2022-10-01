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
        public async Task<ActionResult<int>> Post(Mensajes mensajes)
        {
            //context.Add(Mensajes);
            Dominio.Mensaje ms = new Dominio.Mensaje();// AdicionarMensajes
            ms.AdicionarMensajes(mensajes);


            //AdicionarMensajes
            //await context.SaveChangesAsync();
            return Convert.ToInt16( ms.AdicionarMensajes(mensajes));
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

        [HttpPost]
        public async Task<ActionResult<int>> Post(Users usuarios)
        {
            //context.delete(Usuarios);
            Dominio.Usuario ms = new Dominio.Usuario();// EliminarUsuarios
            ms.EliminarUsuarioPorUserId(usuarios.id);


            //EliminarUsuarios
            //await context.SaveChangesAsync();
            return Convert.ToInt16( ms.EliminarUsuarioPorUserId(usuarios.id));
        }

    }
}

