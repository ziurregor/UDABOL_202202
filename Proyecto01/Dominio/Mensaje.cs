using System;
using System.Collections.Generic;
using Modelo;
using Infrestructura;
using System.Collections;

namespace Dominio
{
    public class Mensaje:IMensaje
    {
        public Mensaje()
        {
        }

        public bool AdicionarMensajes(Modelo.Mensajes mensajes)
        {
            //throw new NotImplementedException();
            List<Modelo.Mensajes> lista = new List<Modelo.Mensajes>();

            lista.Add(mensajes);
            var resp = new Coneccion();
            var sol2 = resp.EscribirTablaMensaje(lista);
            return true;
        }

        public Mensajes EliminarMensajesUltimo(Users users)
        {
            throw new NotImplementedException();
        }

        public List<Mensajes> ListarMensajes()
        {
            throw new NotImplementedException();
        }

        public List<Mensajes> ListarMensajesPorUsuario(Users users)
        {
            throw new NotImplementedException();
        }

        public Mensajes MensajesUltimo(Users users)
        {
            throw new NotImplementedException();
        }
    }
}

