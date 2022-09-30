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

        public List<Users> LeerTabla()
        {
            
            using (ChatSQLiteContext context = new ChatSQLiteContext())
            {
                return context.User.ToList();
                //throw new NotImplementedException();



            }
            
        }


    }
}