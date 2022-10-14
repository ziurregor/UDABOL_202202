using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Modelo;
using Microsoft.Data.Sqlite;
using System.Configuration;
using System.Data.SQLite;

namespace Dominio.CRUD_SQLITE_INSERT_DELETE
{
    public class ROL
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static ROL _instancia = null;

        public ROL()
        {

        }
        public static ROL Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ROL();
                }
                return _instancia;
            }
        }
        public bool insert(Roles obj)
        {
            bool respuesta = true;
            using (SqliteConnection conexion = new SqliteConnection(cadena))
            {
                conexion.Open();

                string query = "insert into ROL (RolId,Nombre) values (@RolId,@Nombre)";

                SqliteCommand cmd = new SqliteCommand(query, conexion);

                cmd.Parameters.Add(new SqliteParameter("@RolId", obj.RolId));
                cmd.Parameters.Add(new SqliteParameter("@Nombre", obj.Nombre));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

        /* public List<Users> LeerTabla()
         {
             using (ChatSQLiteContext context = new ChatSQLiteContext())
             {
                 return context.User.ToList();
             }
         }*/

        public List<Roles> listar()
        {
            List<Roles> Olista = new List<Roles>();

            using (SqliteConnection conexion = new SqliteConnection(cadena))
            {
                conexion.Open();
                string query = "select * from USERS";
                SqliteCommand cmd = new SqliteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SqliteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Olista.Add(new Roles()
                        {
                            RolId = int.Parse(dr["RolId"].ToString()),
                            Nombre = dr["Nombre"].ToString(),
                        }); ;
                    }
                }
            }
            return Olista;
        }

        public bool Delete(Roles obj)
        {
            bool respuesta = true;
            using (SqliteConnection conexion = new SqliteConnection(cadena))
            {
                conexion.Open();

                string query = "delete from ROL where RolId = @RolId";

                SqliteCommand cmd = new SqliteCommand(query, conexion);
                cmd.Parameters.Add(new SqliteParameter("@RolId", obj.RolId));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
            }
            return respuesta;
        }

    }
}
