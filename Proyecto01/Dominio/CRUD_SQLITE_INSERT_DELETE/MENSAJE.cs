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
    public class MENSAJE
    {
        
            private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

            private static MENSAJE _instancia = null;

            public MENSAJE()
            {

            }
            public static MENSAJE Instancia
            {
                get
                {
                    if (_instancia == null)
                    {
                        _instancia = new MENSAJE();
                    }
                    return _instancia;
                }
            }
            public bool insert(Mensajes obj)
            {
                bool respuesta = true;
                using (SqliteConnection conexion = new SqliteConnection(cadena))
                {
                    conexion.Open();

                    string query = "insert into MENSAJES (MensajeId,UseridId,Mensaje) values (@MensajeId,@UseridId,@Mensaje)";

                    SqliteCommand cmd = new SqliteCommand(query, conexion);

                    cmd.Parameters.Add(new SqliteParameter("@MensajeIdId", obj.MensajeId));
                    cmd.Parameters.Add(new SqliteParameter("@UseridId", obj.UseridId));
                    cmd.Parameters.Add(new SqliteParameter("@Mensaje", obj.Mensaje));


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

            public List<Mensajes> listar()
            {
                List<Mensajes> Olista = new List<Mensajes>();

                using (SqliteConnection conexion = new SqliteConnection(cadena))
                {
                    conexion.Open();
                    string query = "select * from MENSAJES";
                    SqliteCommand cmd = new SqliteCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqliteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Olista.Add(new Mensajes()
                            {
                                MensajeId = int.Parse(dr["MensajeId"].ToString()),
                                UseridId = int.Parse(dr["UseridId"].ToString()),
                                Mensaje = dr["Mensaje"].ToString(),

                            }); ;
                        }
                    }
                }
                return Olista;
            }

            public bool Delete(Mensajes obj)
            {
                bool respuesta = true;
                using (SqliteConnection conexion = new SqliteConnection(cadena))
                {
                    conexion.Open();

                    string query = "delete from MENSAJES where  MensajeId = @MensajeId";

                    SqliteCommand cmd = new SqliteCommand(query, conexion);
                    cmd.Parameters.Add(new SqliteParameter("@MensajeId", obj.MensajeId));
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
