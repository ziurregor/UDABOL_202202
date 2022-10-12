using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrestructura;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Modelo;


namespace Test
{
    public class Program
    {
        public static void Main()//string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            Console.WriteLine("Intro use");
            var resp = new Coneccion();
            List<Users> lista = new List<Users>();
            // UserId = 1,
            lista.Add(new Users { Usuario = "Regor", Name = "Roger Ruiz", IsActive = true, Edad = 47,Contraseña="123456" });

            var sol2 = resp.EscribirTabla(lista);


            var usuarios = new Dominio.Usuario();//  Infrestructura.Coneccion();

            foreach (var user in usuarios.ListarUsuarios())
            {
                Console.WriteLine("Intro use"+user.Name);
                Console.WriteLine("Intro use" + user.IsActive);
            }

            Console.Read();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

