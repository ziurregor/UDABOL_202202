using Infrestructura;
using Modelo;
using System.Collections.Generic;
using System;

namespace Dominio
{
    public class Mensaje : IMensaje
    {
        readonly Coneccion repo = new Coneccion();//verificar readonly

        public List<Mensajes> ListarMensajes()
        {
            return repo.ListarMensajes();
        }

        public List<Mensajes> ListarMensajesUsuario(string userName)
        {
            return repo.ListarMensajesUsuario(userName);
        }

        public bool EliminarMensaje(Int32 idMensaje)
        {
            return repo.EliminarMensaje(idMensaje);
        }

        public bool GuardarMensaje(List<Mensajes> mensaje)
        {
            throw new NotImplementedException();
        }

        public bool EliminarMensajesUltimo(Mensajes mensajes)
        {
            throw new NotImplementedException();
        }

        //public bool GuardarMensaje(List<Mensajes> mensaje)
        //{
        //    return repo.GuardarMensaje(mensaje);
        //}
    }
}
