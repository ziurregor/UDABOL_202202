using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

//1.- AÑADIR LA AUTHORIZACION
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;
using System.Data;
using System.Xml.Linq;


namespace WebApplication1.Controllers
{
    //2.- AÑADIR LA AUTHORIZACION
    //[Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize(Roles = "Administrador,Supervisor,Empleado,Jefe")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Administrador,Empleado")]
        public IActionResult Ventas()
        //private static List<Mensajes> Ventas()
        {
            String apiUrl = "http://localhost:6202/api/Mensaje";//"https://localhost:5001/api/CustomerAPI";
            HttpClient client = new HttpClient();

            //var content = new StringContent(JsonConvert.SerializeObject(usuario_p), Encoding.UTF8, "application/json");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(apiUrl).Result;// PostAsJsonAsync(apiUrl, usuario_p).Result;

            //ojo
            List<Mensajes> mensajes = new List<Mensajes>();
            //string apiUrl = "http://localhost:6202/api";//"https://localhost:5001/api/CustomerAPI";

            //HttpClient client = new HttpClient();
            //HttpResponseMessage response = client.GetAsync(apiUrl + string.Format("/Usuario", name)).Result;



            if (response.IsSuccessStatusCode)
            {
                mensajes = JsonConvert.DeserializeObject<List<Mensajes>>(response.Content.ReadAsStringAsync().Result);
            }

            //return mensajes;
            //fin ojo
            return View(mensajes);
        }

        [Authorize(Roles = "Administrador,Supervisor")]
        public IActionResult Compras()
        {
            return View();
        }

        [Authorize(Roles = "Administrador,Supervisor")]
        public IActionResult Clientes()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}