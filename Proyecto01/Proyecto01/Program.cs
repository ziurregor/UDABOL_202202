using System;
using Infrestructura;
using Modelo;

namespace Proyecto01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Coneccion c = new Coneccion();
            Users nu = new Users() { UserId = 1, Name = "Roger Ruiz", Contraseña = "123456", Edad = 30, IsActive = true, Usuario = "Usuario1" };
            //var a = c.ModificarUsuario(nu);

            var a = c.OptieneUsuarioPorUsername("Usuario1");

            Console.WriteLine("Resp="+a.Name);
        }
    }
}

