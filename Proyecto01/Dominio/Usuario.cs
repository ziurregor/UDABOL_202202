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

        public bool AdicionarUsuario(Users users)
        {
            //throw new NotImplementedException();
            //new Users { Usuario = "Regor", Name = "Roger Ruiz", IsActive = true, Edad = 47, Contraseña = "123456" }
            return true;
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

        public bool LoginUsuario(string usuario, string contrasena)
        {
            //throw new NotImplementedException();



            return true;
        }

        public Users UsuarioPorUserId(int userId)
        {
            throw new NotImplementedException();
        }
    }
}

