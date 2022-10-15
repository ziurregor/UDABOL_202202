using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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

        public bool EliminarRol(int idRol)
        {
            throw new NotImplementedException();
        }

        public bool EliminarUsuario(int Id)
        {
            var itemIndexInicial = 0;
            var itemIndexFinal = 0;
            using (ChatSQLiteContext context = new ChatSQLiteContext())
            {
                itemIndexInicial = context.User.ToList().Count;
                context.User.Remove(OptieneUsuarioPorUserId(Id));
                context.SaveChanges();
                itemIndexFinal = context.User.ToList().Count;
            }
            return itemIndexInicial - 1 == itemIndexFinal ? true : false;
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

        public bool GuardarUsuario(Users users)
        {
            var itemIndexInicial = 0;
            var itemIndexFinal = 0;
            using (ChatSQLiteContext context = new ChatSQLiteContext())
            {
                itemIndexInicial= context.User.ToList().Count;
                context.User.Add(users);
                context.SaveChanges();
                itemIndexFinal = context.User.ToList().Count;
            }
            return itemIndexInicial+1 == itemIndexFinal ? true : false;

        }

        public List<Users> LeerTabla()
        {
            var lista = new List<Users>();
            using (ChatSQLiteContext context = new ChatSQLiteContext())
            {

                lista = context.User.ToList();
            }
            return lista;
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

        public bool ModificarUsuario(Users users)// public bool editar(persona obj)
        {
            //throw new NotImplementedException();
            using (ChatSQLiteContext context = new ChatSQLiteContext())
            {
                var a = context.Update(users);
                context.SaveChanges();
            }
            return true;
        }

        public Modelo.Users OptieneUsuarioPorUserId(int UserId)
        {
            //throw new NotImplementedException();
            //return new Modelo.Users { UserId = 1, Name ="Roger Ruiz", Contraseña ="123456", Edad =30, IsActive =true, Usuario="Usuario1"};
            Users user = new Users();
            using (ChatSQLiteContext context = new ChatSQLiteContext())
            {
                user= context.User.Find(UserId);
                

            }
            return user;

        }
        //https://www.learnentityframeworkcore5.com/dbset
        public Users OptieneUsuarioPorUsername(string usuario)
        {
            Users user = new Users();
            using (ChatSQLiteContext context = new ChatSQLiteContext())
            {
                //user = context.User.Find(usuario);
                var u = context.User.Where(p => p.Usuario == usuario).FirstOrDefault();
                if (u == null)
                {
                    return null;
                }
                else {
                    return u;
                }
            }


            //return user;
        }


    }
}