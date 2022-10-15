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

            var resp = new Coneccion();
            List<Users> lista = new List<Users>();
            // UserId = 1,
            lista.Add(users); //new Users { Usuario = "Regor", Name = "Roger Ruiz", IsActive = true, Edad = 47, Contraseña = "123456" });

            return resp.EscribirTabla(lista);


             
        }

        public bool EliminarUsuarioPorUserId(int userId)
        {
            return repo.EliminarUsuario(userId);
        }

        public List<Users> ListarUsuarios()
        {
            //throw new NotImplementedException();
            return repo.LeerTabla();
        }

        public List<Users> ListarUsuariosActivos()
        {
            List<Users> lista = repo.LeerTabla();

            foreach (var users in lista)//de la lista de usuarios escoje los que is active tienen null
            {
                if (!users.IsActive)
                    lista.Remove(users);

            }

            return lista;
        }

        public List<Users> ListarUsuariosAdministradores()
        {
            //return repo.ListarUsuariosAdministradores();
            List<Users> lista = repo.LeerTabla();

            foreach (var users in lista)//de la lista de usuarios escoje los que is active tienen null
            {
                if (!users.IsActive)
                    lista.Remove(users);

            }

            return lista;
        }

        public List<Users> ListarUsuariosInActivos()
        {
            //return repo.LeerTabla(false);
            List<Users> lista = repo.LeerTabla();

            foreach (var users in lista)//de la lista de usuarios escoje los que is active tienen null
            {
                if (users.IsActive)
                    lista.Remove(users);

            }

            return lista;
        }

        public bool Login(string userName, string Password)
        {
            //return repo.Login(userName, Password);
            //se busca el usuario y el password de la lista de usuarios

            var user = repo.OptieneUsuarioPorUsername(userName);

            if (user != null)
            {
                if (user.Usuario == userName || user.Contraseña == Password)
                    return true;
            }
            return false;


        }

        public Users UsuarioPorUserId(int userId)
        {
            return repo.OptieneUsuarioPorUserId(userId);
        }

        public Users UsuarioPorNombre(string usuario)
        {
            return repo.OptieneUsuarioPorUsername(usuario);
        }


        Users IUsuario.EliminarUsuarioPorUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public bool LoginUsuario(string usuario, string contrasena)
        {
            //return repo.Login(userName, Password);
            //se busca el usuario y el password de la lista de usuarios

            var user = repo.OptieneUsuarioPorUsername(usuario);

            if (user.Usuario == usuario || user.Contraseña == contrasena)
                return true;
            return false;
        }
    }
}

