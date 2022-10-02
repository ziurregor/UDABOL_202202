using System;
using System.Collections.Generic;
using Modelo;

namespace Infrestructura
{
    public class PostgreConeccion : IConeccion
    {
        public PostgreConeccion()
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

        public bool EscribirTabla(List<Users> lista)
        {
            throw new NotImplementedException();
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public List<Users> LeerTabla()
        {
            throw new NotImplementedException();
        }

        public bool OptieneUsuario(int UserId)
        {
            throw new NotImplementedException();
        }
    }
}

