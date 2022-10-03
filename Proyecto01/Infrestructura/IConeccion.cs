using System;
using System.Collections.Generic;
using Modelo;

namespace Infrestructura
{
    interface IConeccion
    {
        public Boolean Conectar(String cadenaDeConexion, Type tipo);

        public Boolean Conectar();

        public List<Users> LeerTabla();

        public Boolean EscribirTabla(List<Users> lista);

        public Boolean EliminarRegistro(Int32 Id);

        public Boolean Guardar();

        public Modelo.Users OptieneUsuario(Int32 UserId);

        public Modelo.Users OptieneUsuarioPorUsername(String usuario);

    }
}

