using Infrestructura;
using Modelo;
using System.Collections.Generic;
using System;

namespace Dominio
{
    public class Mensaje: IMensaje
    {
        readonly Infrestructura.Mensaje repo = new Infrestructura.Mensaje();//verificar readonly

        public List<Mensajes> ListarMensajes()
        {
            return repo.LeerTabla();
        }

        public List<Mensajes> ListarMensajesUsuario(string userName)
        {
            return repo.ListarMensajesUsuario(userName);
        }

        public bool EliminarMensaje(Int32 idMensaje)
        {
            return repo.EliminarRegistro(idMensaje);
        }

        public bool GuardarMensaje(Mensajes mensaje)
        {
            return repo.GrabaRegistro(mensaje);
        }

        public Boolean RecuperaMensaje(Int32 Id)
        {
            return repo.RecuperaRegistro(Id);
        }

        public bool EliminarMensajesUltimo(Mensajes mensajes)
        {
            return repo.EliminarMensajesUltimo(mensajes);
        }

        public bool GuardarMensaje(List<Mensajes> mensaje)
        {
            return repo.GuardarMensaje(mensaje);
        }
    }
}
