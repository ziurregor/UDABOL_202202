using System;
using System.Collections.Generic;
using System.Linq;
using Modelo;

namespace Infrestructura
{
    //public class ConexionTexto : IConexion
    public class Coneccion : IConeccion
    {
        ChatSQLiteContext db;


        public bool Conectar(string cadenaDeConexion, Type tipo)
        {
            throw new NotImplementedException();
        }

        public bool Conectar()
        {
            db = new ChatSQLiteContext();
            return true;
        }

        public bool EliminarRegistro(int Id)
        {
            Users user = new Users();
            ChatSQLiteContext context = new ChatSQLiteContext();
            user = context.User.Find(Id);
            if (user != null)
            {
                user.IsActive = false;
                context.User.Update(user);
                return true;
            }
            return false;
        }

        public bool EscribirTabla(List<Users> lista)
        {
            var itemIndex = 0;
            using (ChatSQLiteContext context = new ChatSQLiteContext())
            {
                foreach (var users in lista)
                {
                    users.Password = Auxiliar.Encriptar(users.Password);
                    context.User.Add(users);
                }
                context.SaveChanges();
                itemIndex = context.User.ToList().Count;

            }
            return itemIndex == lista.Count ? true : false;
        }

        public bool Guardar(Users user)
        {
            try
            {
                ChatSQLiteContext context = new ChatSQLiteContext();
                user.Password = Auxiliar.Encriptar(user.Password);
                context.User.Update(user);
                return true;
            }
            catch (Exception e)
            {
                throw new ArgumentNullException("Error al Guardar un usuario", e);
            }

        }

        public List<Users> LeerTabla(bool? isactive)
        {
            ChatSQLiteContext context = new ChatSQLiteContext();
            if (isactive == null)
            {
                return context.User.ToList();
            }
            else if (isactive == true)
            {
                return context.User.Where(Users => Users.IsActive == true).ToList();
            }
            else
            {
                return context.User.Where(Users => Users.IsActive == false).ToList();
            }

        }
        /// <summary>
        /// Obtener ususario por Id
        /// </summary>
        /// <param name="Id">Id De usuario</param>
        /// <returns>Usuario</returns>
        public Users UsuarioPorUserId(Int32 Id)
        {
            Users user = new Users();
            ChatSQLiteContext context = new ChatSQLiteContext();
            user = context.User.Find(Id);
            return user;
        }

        public List<Users> ListarUsuariosAdministradores()
        {
            ChatSQLiteContext context = new ChatSQLiteContext();
            return context.User.Where(Users => Users.Rol.Nombre == "Administrador").ToList();
        }

        public bool Login(string userName, string Password)
        {
            Users users = new Users();
            ChatSQLiteContext context = new ChatSQLiteContext();
            users = (Users)(context.User.Where(User=> User.Usuario == userName));
            if (users != null)
            {
                string password1 = users.Password;
                string password2 = Auxiliar.DesEncriptar(password1);
                if (password2 == Password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public List<Mensajes> ListarMensajes()
        {
            throw new NotImplementedException();
        }
        public List<Mensajes> ListarMensajesUsuario(string userName)
        {
            throw new NotImplementedException();
        }
        public EliminarMensaje(Int32 idMensaje)
        {
            throw new NotImplementedException();
        }
        public GuardarMensaje(Mensajes mensaje)
        {
            throw new NotImplementedException();
        }
        public List<Roles> ListarRoles()
        {
            throw new NotImplementedException();
        }
        public bool GuardarRol(Roles rol)
        {
            throw new NotImplementedException();
        }
        public bool EliminarRol(Int32 idRol)
        {
            throw new NotImplementedException();
        }
    }
}