using System;
using System.Collections.Generic;
using Modelo;

namespace Infrestructura
{
    public class Rol:IRol
    {
        public Rol()
        {
        }

        public bool Conectar(string cadenaDeConexion, Type tipo)
        {
            throw new NotImplementedException();
        }

        public bool Conectar()
        {
            throw new NotImplementedException();
        }

        public bool EliminarRegistro(int Id)
        {
            throw new NotImplementedException();
        }

        public bool GrabaRegistro(Roles roles)
        {
            throw new NotImplementedException();
        }

        public List<Roles> LeerTabla()
        {
            throw new NotImplementedException();
        }

        public bool RecuperaRegistro(int Id)
        {
            throw new NotImplementedException();
        }

        public bool EliminarRolUltimo(Roles Rol)
        {
            throw new NotImplementedException();
        }
    }
}

