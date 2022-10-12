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
            //return (List<Users>)user.ListarUsuarios();

        }

        //IEnumerable<ChatUser> Get()
        //{
        //    var user = new ChatUsersSqliteRepository();
        //    return user.List();


       }
}

