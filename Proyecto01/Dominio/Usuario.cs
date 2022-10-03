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
            return repo.LeerTabla();
            //return repo.LeerTabla(null);
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

        public Users UsuarioPorUserId(int userId)
        {
            return repo.OptieneUsuario(userId);
        }

        public bool Login(string userName, string Password)
        {
            //return repo.Login(userName, Password);
            //se busca el usuario y el password de la lista de usuarios
            return true;

        }
    }
}

