using Infrestructura;
using Modelo;
using System.Collections.Generic;
using System;

namespace Dominio
{
    public class Rol: IRol
    {
        readonly Coneccion repo = new Coneccion();//verificar readonly

        public List<Roles> ListarRoles()
        {
            return repo.ListarRoles();
        }

        public bool GuardarRol(Roles rol)
        {
            return repo.GuardarRol(rol);
        }

        public bool EliminarRol(Int32 idRol)
        {
            return repo.EliminarRol(idRol);
        }
    }
}
