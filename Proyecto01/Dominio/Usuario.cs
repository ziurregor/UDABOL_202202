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

        public Users EliminarUsuarioPorUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public List<Users> ListarUsuarios()
        {
            //throw new NotImplementedException();
            return repo.LeerTabla();
        }

        public List<Users> ListarUsuariosActivos()
        {
            throw new NotImplementedException();
        }

        public List<Users> ListarUsuariosAdministradores()
        {
            throw new NotImplementedException();
        }

        public List<Users> ListarUsuariosInActivos()
        {
            throw new NotImplementedException();
        }

        public Users UsuarioPorUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}

