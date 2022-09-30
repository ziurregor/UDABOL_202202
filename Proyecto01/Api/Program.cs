using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

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
        //public async bool mensajeDelete(Mensajes msj)
        //{
        //    var mensaje = await _repo.GetMensajeByIdAsync(msj.MensajeId); //metodo verifica si mensaje existe

        //    if(mensaje == null) 
		      //  return false;
        //    boolean resp = await _repo.Delete(msj.MensajeId); // Metodo borra mensaje

        //    if(!await _repo.SaveAll()) //Verifica Borrado en repositorio
        //    {
        //        BadRequest(“No se pudo borrar el mensaje”);
        //        return false; //Excepcion
        //    }
        //    return true;
        //}

        //public async bool userDelete(Users user)
        //{
        //    var usuario = await _repo.GetUserByIdAsync(user.UserId); //metodo verifica si usuario existe

        //    if(var == null) 
        //        return false;
        //    boolean resp = await _repo.Delete(user.UserId); //Metodo borra Usuario

        //    if(!await _repo.SaveAll()) //Verifica Borrado en repositorio
        //    {
        //         BadRequest(“No se pudo borrar el mensaje”); //Excepcion
        //         return false;
        //    }
        //    return true;
        //}
            //POst
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
