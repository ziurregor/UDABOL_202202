using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dominio;
using Modelo;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : Controller
    {
        // GET: /<controller>/  api/Rol
        [HttpPost]
        public int Post(Modelo.Rol Rol)
        //Task<ActionResult<int>> Post(Modelo.Rol Rol)
        {
            // Boolean respuesta = false;

            Dominio.Mensaje ms = new Dominio.Mensaje();// AdicionarRol

            var a = ms.EliminarRolUltimo(Rol);

            return 1;//ver como devolver OK
        }

        // DELETE
        [HttpDelete("{id}")]
        public Boolean DeleteRolId (Int32 id)
        {
            Dominio.Rol ms = new Dominio.Rol();
            boolean encontrado = false;
            List<Roles> listRoles = ms.ListarRoles()
            for(int i = 0; i < listRoles.Count; i++)
            {
                if(listRoles[i].RolId == id)
                {
                    encontrado = true; //verificamos si rol existe
                }
            }
            if(encontrado){
                return ms.EliminarRol(id); // eliminamos Mensaje por ID
            }else{
                return false;
            }
        }

        //get http://localhost:PUER/api/Mensaje   ==devuelve la lista de Rol
        //get http://localhost:PUER/api/Usuario   ==devuelve la lista de usuarios
        //get http://localhost:PUER/api/Usuario/{Userid}   ==devuelve un usuario
    }
}

