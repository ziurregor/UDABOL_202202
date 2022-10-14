using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using Microsoft.Data.Sqlite;
using Infrestructura;
using System.Configuration;

using System.Data.SQLite;

namespace Dominio.CRUD_SQLITE_INSERT_DELETE
{
    public class USERS
    {
            private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

            private static USERS _instancia = null;

            public USERS()
            {
            }
            public static USERS Instancia
            {
                get
                {
                    if (_instancia == null)
                    {
                        _instancia = new USERS();
                    }
                    return _instancia;
                }
            }

        public bool insert(Users obj)
            {
                bool respuesta = true;
                using (SqliteConnection conexion = new SqliteConnection(cadena))
                {
                    conexion.Open();

                    string query = "insert into USERS (UserId,Usuario,Name,IsActive,Edad,Contraseña) values (@UserId,@Usuario,@Name,@IsActive,@Edad,@Contraseña)";

                    SqliteCommand cmd = new SqliteCommand(query, conexion);

                    cmd.Parameters.Add(new SqliteParameter("@UserId", obj.UserId));
                    cmd.Parameters.Add(new SqliteParameter("@Usuario", obj.Usuario));
                    cmd.Parameters.Add(new SqliteParameter("@Name", obj.Name));
                    cmd.Parameters.Add(new SqliteParameter("@IsActive", obj.IsActive));
                    cmd.Parameters.Add(new SqliteParameter("@Edad", obj.Edad));
                    cmd.Parameters.Add(new SqliteParameter("@Contraseña", obj.Contraseña));

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

            public List<Users> listar()
            {
                List<Users> Olista = new List<Users>();

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
                            Olista.Add(new Users()
                            {
                                UserId = int.Parse(dr["UserId"].ToString()),
                                Usuario = dr["Usuario"].ToString(),
                                Name = dr["Name"].ToString(),
                                IsActive = bool.Parse(dr["IsActive"].ToString()),
                                Edad =  int.Parse (dr["Edad"].ToString()),
                                Contraseña = dr["Contraseña"].ToString(),
                                 


                            }); ;
                        }
                    }
                }
                return Olista;
            }

            public bool Delete(Users obj)
            {
                bool respuesta = true;
                using (SqliteConnection conexion = new SqliteConnection(cadena))
                {
                    conexion.Open();

                    string query = "delete from USERS where UserId = @UserId";

                    SqliteCommand cmd = new SqliteCommand(query, conexion);
                    cmd.Parameters.Add(new SqliteParameter("@UserId", obj.UserId));
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
