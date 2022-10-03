using System;
using Modelo;
using System.Collections.Generic;

namespace Infrestructura
{
    public interface IRol
    {
        public Boolean Conectar(String cadenaDeConexion, Type tipo);

        public Boolean Conectar();

        public List<Roles> LeerTabla();

        public Boolean RecuperaRegistro(Int32 Id);

        public Boolean EliminarRegistro(Int32 Id);

        public Boolean GrabaRegistro(Modelo.Roles roles);
    }
}

