using Modelo;
using System.Collections.Generic;
using System;

namespace Dominio
{
    public interface IMensaje
    {
        public List<Mensajes> ListarMensajes();

        public List<Mensajes> ListarMensajesUsuario(string userName);

        public bool EliminarMensaje(Int32 idMensaje);

        public bool GuardarMensaje(Mensajes mensaje);
    }
}
