using System;
using System.Collections.Generic;
using System.Linq;
using Modelo;

namespace Infrestructura
{
    public class Mensaje:IMensaje
    {
        public Mensaje()
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

        public bool GrabaRegistro(Mensajes mensajes)
        {
            throw new NotImplementedException();
        }

        public List<Mensajes> LeerTabla()
        {
            var lista = new List<Modelo.Mensajes>();
            using (ChatSQLiteContext context = new ChatSQLiteContext())
            {

                lista = context.Mensaje.ToList();
            }
            return lista;
        }

        public bool RecuperaRegistro(int Id)
        {
            throw new NotImplementedException();
        }
    }
}

