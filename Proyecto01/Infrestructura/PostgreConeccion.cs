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

        public bool EliminarMensaje(int idMensaje)
        {
            throw new NotImplementedException();
        }

        public bool EliminarRegistro(int Id)
        {
            throw new NotImplementedException();
        }

        public bool EliminarRol(int idRol)
        {
            throw new NotImplementedException();
        }

        public bool EliminarUsuario(int Id)
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

        public bool GuardarMensaje(List<Mensajes> mensaje)
        {
            throw new NotImplementedException();
        }

        public bool GuardarRol(Roles rol)
        {
            throw new NotImplementedException();
        }

        public bool GuardarUsuario(Users users)
        {
            throw new NotImplementedException();
        }

        public List<Users> LeerTabla()
        {
            throw new NotImplementedException();
        }

        public List<Mensajes> ListarMensajes()
        {
            throw new NotImplementedException();
        }

        public List<Mensajes> ListarMensajesUsuario(string userName)
        {
            throw new NotImplementedException();
        }

        public List<Roles> ListarRoles()
        {
            throw new NotImplementedException();
        }

        public bool ModificarUsuario(Users users)
        {
            throw new NotImplementedException();
        }

        public bool OptieneUsuario(int UserId)
        {
            throw new NotImplementedException();
        }

        public Users OptieneUsuarioPorUserId(int UserId)
        {
            throw new NotImplementedException();
        }

        public Users OptieneUsuarioPorUsername(string usuario)
        {
            throw new NotImplementedException();
        }

        //Users IConeccion.OptieneUsuario(int UserId)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

