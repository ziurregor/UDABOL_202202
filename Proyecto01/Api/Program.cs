using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Modelo;

namespace Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //
            CreateHostBuilder(args).Build().Run();

            //var con = new 

        }
        //GEt
        //put

        //delete
        public Boolean mensajeDelete(Mensajes msj)
        {
            //Mensajes mensaje = await _repo.GetMensajeByIdAsync(msj.MensajeId); //verifica si mensaje existe

            //if (mensaje == null)
            //    return false;
            //Boolean resp = await _repo.Delete(msj.MensajeId); //borra mensaje

            //if (resp) //Verifica Borrado
            //{
            //    BadRequest(“No se pudo borrar el mensaje”);
            //    return false; //Excepcion
            //}
            return true;
        }

        public Boolean userDelete(Users user)
        {
            //Users usuario = await _repo.GetUserByIdAsync(user.UserId); // verifica si usuario existe

            //if (usuario == null)
            //    return false;
            //boolean resp = await _repo.Delete(user.UserId); //borra Usuario

            //if (resp) //Verifica Borrado
            //{
            //    BadRequest(“No se pudo borrar el mensaje”); //Excepcion
            //    return false;
            //}
            return true;
        }
        //POst
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
