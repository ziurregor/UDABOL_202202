using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI_EF_MVC_Core.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Net.Http.Headers;

namespace WebAPI_EF_MVC_Core.Controllers
{
    public class HomeController : Controller
    {
        //GET: Home
        public IActionResult Login()
        {
            List<Users> customers = SearchCustomers("");
            return View(customers);
        }
        
        // GET: Home
        public IActionResult Index()
        {
            List<Users> customers = SearchCustomers("");
            return View(customers);
        }



        [HttpPost]
        public IActionResult Login(string name)
        {
            List<Users> customers = SearchCustomers(name);
            return View(customers);
        }

        private static List<Users> SearchCustomers(string name)
        {
            List<Users> users = new List<Users>();
            string apiUrl = "http://localhost:6202/api";//"https://localhost:5001/api/CustomerAPI";

            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(apiUrl + string.Format("/Usuario", name)).Result;

           

            if (response.IsSuccessStatusCode)
            {
                users = JsonConvert.DeserializeObject<List<Users>>(response.Content.ReadAsStringAsync().Result);
            }

            return users;
        }

        [HttpPost]
        public IActionResult Index(string Usuario, string Password)
        {
            var customers = ProcLogin(Usuario, Password);
            return View(customers);
        }
        private static Boolean ProcLogin(string Usuario,string Password)
        {
            List<Users> users = new List<Users>();
            string apiUrl = "http://localhost:6202/api/Login";//"https://localhost:5001/api/CustomerAPI";

            HttpClient client = new HttpClient();

            var content = new StringContent(JsonConvert.SerializeObject(Usuario), Encoding.UTF8, "application/json");
            //client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //+ string.Format("/Login")

            Users u = new Users()  { Usuario = Usuario, Contraseña = Password };
            //new User { Name = "Roger.Ruiz@jalasoft.org", IsActive = true }
            HttpResponseMessage response = client.PostAsJsonAsync( apiUrl , u).Result;
            //HttpResponseMessage response = client.GetAsync(apiUrl + string.Format("/GetCustomers?name={0}", name)).Result;
            if (response.IsSuccessStatusCode)
            {
                var res= JsonConvert.DeserializeObject<Boolean>(response.Content.ReadAsStringAsync().Result);
            }

            return true;
        }




    }
}