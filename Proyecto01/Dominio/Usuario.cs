using System;
using System.Collections.Generic;
using Modelo;
using Infrestructura;

namespace Dominio
{
    public class Usuario:IUsuario
    {
        readonly Coneccion repo = new Coneccion();//verificar readonly

        public Usuario()
        {
        }

        public bool EliminarUsuarioPorUserId(int userId)
        {
            return repo.EliminarRegistro(userId);
        }

        public List<Users> ListarUsuarios()
        {
            return repo.LeerTabla(null);
        }

        public List<Users> ListarUsuariosActivos()
        {
            return repo.LeerTabla(true);
        }

        public List<Users> ListarUsuariosAdministradores()
        {
            return repo.ListarUsuariosAdministradores();
        }

        public List<Users> ListarUsuariosInActivos()
        {
            return repo.LeerTabla(false);
        }

        public Users UsuarioPorUserId(int userId)
        {
            return repo.UsuarioPorUserId(userId);
        }

        public bool Login(string userName, string Password)
        {
            return repo.Login(userName, Password);
        }
    }
}

