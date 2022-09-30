using System;
using System.Collections.Generic;
using Modelo;

namespace Infrestructura
{
    interface IConeccion
    {
        public Boolean Conectar(String cadenaDeConexion, Type tipo);

        public Boolean Conectar();

        public List<Users> LeerTabla(bool? isactive);

        public Boolean EscribirTabla(List<Users> lista);

        public Boolean EliminarRegistro(Int32 Id);

        public Boolean Guardar(Users user);

        public Users UsuarioPorUserId(Int32 Id);

        public List<Users> ListarUsuariosAdministradores();

        public bool Login(string userName, string Password);
    }
}

