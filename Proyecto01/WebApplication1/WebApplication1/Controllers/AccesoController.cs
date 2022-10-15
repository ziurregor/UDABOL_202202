using Microsoft.AspNetCore.Mvc;

using WebApplication1.Models;
using WebApplication1.Data;

//1.- REFERENCES AUTHENTICATION COOKIE
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http.Headers;
using System.Data;

namespace WebApplication1.Controllers
{
    public class AccesoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //USAR REFERENCIAS Models y Data
        [HttpPost]
        public async Task<IActionResult> Index(User _usuario)
        {
            DA_Usuario _da_usuario = new DA_Usuario();

            var usuario_p = _da_usuario.ValidarUsuario(_usuario.Usuario,_usuario.Contraseña);

            if (usuario_p != null)
            {

                //2.- CONFIGURACION DE LA AUTENTICACION
                #region AUTENTICACTION
                var claims = new List<Claim>();
                //{
                //    new Claim(ClaimTypes.Name, usuario.Nombre),
                //    new Claim("Correo", usuario.Correo),
                //};
                //foreach (string rol in usuario.Roles) {
                //    claims.Add(new Claim(ClaimTypes.Role, rol));
                //}
                claims.Add(new Claim(ClaimTypes.Role, "Administrador"));
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                #endregion

                String apiUrl = "http://localhost:6202/api/Login";//"https://localhost:5001/api/CustomerAPI";

                HttpClient client = new HttpClient();

                var content = new StringContent(JsonConvert.SerializeObject(usuario_p), Encoding.UTF8, "application/json");
                //client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //+ string.Format("/Login")

                //Usuario u = new Usuario() { Usuario = Usuario, Contraseña = Password };
                //new User { Name = "Roger.Ruiz@jalasoft.org", IsActive = true }
                HttpResponseMessage response = client.PostAsJsonAsync(apiUrl, usuario_p).Result;

                
                //var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                //Roles = "Administrador,Empleado")]

                return RedirectToAction("Index", "Home");
            }
            else {
                return View();
            }
            
        }

        public async Task<IActionResult> Salir()
        {
            //3.- CONFIGURACION DE LA AUTENTICACION
            #region AUTENTICACTION
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            #endregion

            return RedirectToAction("Index");

        }

    }
}
