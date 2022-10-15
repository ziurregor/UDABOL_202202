using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Microsoft.Extensions.Hosting;
using System.Text.Json.Serialization;
//using Newtonsoft.Json;
using Modelo;
using Dominio;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LoginController : Controller
    {
        // GET: /<controller>/

        //[HttpPost]
        //public IActionResult Post([FromBody] dynamic payload)
        //{
        //    return Json(new { Ok = true });
        //}

        [HttpPost]
        //public Boolean Post(String usuario, String password)
        public Boolean VerificarLogin([FromBody] Modelo.Users  model)
        {
            //var data = JsonConvert.DeserializeObject<Modelo.Users>(model.ToString()); ;
            //JsonConvert.DeserializeObject<dynamic>(model.ToString());
            Usuario user = new Dominio.Usuario();
            return user.Login((String)model.Usuario, (String)model.Contraseña);
            //if ((String)model.Usuario == "regor" ||  == "123456")
            //return true;
            //return false;
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}

