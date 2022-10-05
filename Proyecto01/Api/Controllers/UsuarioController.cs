﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dominio;
using Modelo;
using System.Collections;

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
        }

        [HttpPost]
        public int Post(Modelo.Users users)
        //Task<ActionResult<int>> Post(Modelo.Usuarios usuarios)
        {
            // Boolean respuesta = false;
            Dominio.Usuario us = new Dominio.Usuario();// AdicionarUsuarios

            return us.AdicionarUsuario(users)?1:0;
           //ver como devolver OK
        }

        //[HttpPut("{id:int}")]
        //public async Task<ActionResult> Put(int id, Mensajes mensajes)
        //{
        //    Console.WriteLine("modificar");
        //    var mesnajesExiste = await MensajesExiste(id);
        //    Console.WriteLine("mensaje no existente: " + MensajesExiste);

        //    if (!MesajesExiste)
        //    {
        //        return NotFound();
        //    }

        //    context.Update(Mensajes);
        //    await context.SaveChangesAsync();
        //    return NoContent();
        //}
    }
}

