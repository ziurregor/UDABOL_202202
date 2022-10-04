using Infrestructura;
using Modelo;
using System.Collections.Generic;
using System;

namespace Dominio
{
    public class Rol: IRol
    {
        readonly Infrestructura.Rol repo = new Infrestructura.Rol();//verificar readonly

        public List<Roles> ListarRoles()
        {
            return repo.LeerTabla();
        }

        public bool GuardarRol(Roles rol)
        {
            return repo.GrabaRegistro(rol);
        }

        public bool EliminarRol(Int32 idRol)
        {
            return repo.EliminarRegistro(idRol);
        }

        public Boolean RecuperaRol(Int32 Id)
        {
            return repo.RecuperaRegistro(Id);
        }
    }
}
