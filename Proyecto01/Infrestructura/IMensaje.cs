using System;
using Modelo;
using System.Collections.Generic;

namespace Infrestructura
{
    public interface IMensaje
    {
        public Boolean Conectar(String cadenaDeConexion, Type tipo);

        public Boolean Conectar();

        public List<Mensajes> LeerTabla();

        public Boolean RecuperaRegistro(Int32 Id);

        public Boolean EliminarRegistro(Int32 Id);

        public Boolean GrabaRegistro(Modelo.Mensajes mensajes);


    }
}

