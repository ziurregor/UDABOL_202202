using Modelo;
using System.Collections.Generic;
using System;

namespace Dominio
{
    public interface IRol
    {
        public List<Roles> ListarRoles();

        public bool GuardarRol(Roles rol);

        public bool EliminarRol(Int32 idRol);

        public bool EliminarRolUltimo(Roles Rol);
    }
}
