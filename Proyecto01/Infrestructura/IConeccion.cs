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

        public Boolean EliminarUsuario(Int32 Id);

        public Boolean ModificarUsuario(Users users);


        public Boolean GuardarUsuario(Users users);

        public Modelo.Users OptieneUsuarioPorUserId(int UserId);

        public Modelo.Users OptieneUsuarioPorUsername(String usuario);

        public Boolean EliminarMensaje(Int32 idMensaje);

        public List<Roles> ListarRoles();

        public bool GuardarRol(Roles rol);

        public bool EliminarRol(Int32 idRol);

        public List<Mensajes> ListarMensajes();

        public List<Mensajes> ListarMensajesUsuario(string userName);

        public bool GuardarMensaje(List<Mensajes> mensaje);
    }
}

