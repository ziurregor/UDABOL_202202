using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrestructura;
using Microsoft.AspNetCore.Hosting;
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

            //Console.ReadLine();
            var resp = new Coneccion();
            var sol1 = resp.Conectar();

            List<Users> lista = new List<Users>();
            lista.Add(new Users { Usuario = "Regor", Name = "Roger Ruiz", IsActive = true, Edad = 47,Contraseña="123456" });
        //        public int UserId { get; set; }
        //public string? Usuario { get; set; }
        //public string? Name { get; set; }
        //public bool IsActive { get; set; }
        //public int Edad { get; set; }
        //public string? Contraseña { get; set; }



        var sol2 = resp.EscribirTabla(lista);


        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

