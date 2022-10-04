using System;
using System.Collections.Generic;
using Modelo;

namespace Dominio
{
    public interface IUsuario
    {
        public List<Users> ListarUsuarios();

        public List<Users> ListarUsuariosActivos();

        public List<Users> ListarUsuariosInActivos();

        public List<Users> ListarUsuariosAdministradores();

        public Users UsuarioPorUserId(int userId);

        public Users UsuarioPorNombre(string usuario);

        public bool EliminarUsuarioPorUserId(int userId);//solo elimnado logi lo que quiere decir Update Isactive a false

        public bool Login(string userName, string Password);

    }
}

