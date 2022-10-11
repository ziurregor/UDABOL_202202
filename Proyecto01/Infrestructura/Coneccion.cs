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

        public bool EscribirTabla(List<Users> lista)
        {
            var itemIndex=0;
            using (ChatSQLiteContext context = new ChatSQLiteContext())
            {
                foreach (var users in lista)
                {
                    context.User.Add(users);
                }
                context.SaveChanges();
                 itemIndex = context.User.ToList().Count;// .IndexOf(newTodo);

            }
            return itemIndex== lista.Count?true:false;
        }


        public bool EscribirTablaMensaje(List<Mensajes> lista)
        {
            var itemIndex = 0;
            using (ChatSQLiteContext context = new ChatSQLiteContext())
            {
                foreach (var mensajes in lista)
                {
                    context.Mensaje.Add(mensajes);
                }
                context.SaveChanges();
                itemIndex = context.Mensaje.ToList().Count;// .IndexOf(newTodo);

            }
            return itemIndex == lista.Count ? true : false;
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

        public List<Users> LeerTabla()
        {
            
            using (ChatSQLiteContext context = new ChatSQLiteContext())
            {
                return context.User.ToList();
                //throw new NotImplementedException();



            }
            
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

        public Modelo.Users OptieneUsuario(int UserId)
        {
            //throw new NotImplementedException();
            return new Modelo.Users { UserId = 1, Name ="Roger Ruiz", Contraseña ="123456", Edad =30, IsActive =true, Usuario="Usuario1"};
        }

        public Users OptieneUsuarioPorUsername(string usuario)
        {
            throw new NotImplementedException();
        }


    }
}