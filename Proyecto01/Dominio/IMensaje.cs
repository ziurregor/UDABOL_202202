using System;
using Modelo;
using System.Collections.Generic;

namespace Dominio
{
    public interface IMensaje
    {
        public List<Mensajes> ListarMensajes();

        public List<Mensajes> ListarMensajesPorUsuario(Users users);

        public Mensajes MensajesUltimo(Users users);

        public Mensajes EliminarMensajesUltimo(Users users);

        public bool AdicionarMensajes(Mensajes mensajes);
    }
}

