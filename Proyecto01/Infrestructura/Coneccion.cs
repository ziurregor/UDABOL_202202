using System;
using System.Collections.Generic;
using Modelo;

namespace Infrestructura
{
    //public class ConexionTexto : IConexion
    public class Coneccion : IConeccion
    {
        ChatSQLiteContext db ;

        public  bool Conectar(string cadenaDeConexion, Type tipo)
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
            foreach (var users in lista)
            {
                db.User.Add(users);
                    //new User { Name = "Roger.Ruiz@jalasoft.org", IsActive = true });
            }
                return true;
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public List<Users> LeerTabla()
        {
            throw new NotImplementedException();
        }
    }
}

