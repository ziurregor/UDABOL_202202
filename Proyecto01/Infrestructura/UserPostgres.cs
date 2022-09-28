using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Infrestructura
{
    internal class UserPostgres
    {
        
        //insert
        public async Task Add(User user)
        {
            string commandText = $"INSERT INTO {user} (UserId, Usuario) VALUES (@UserId, @Usuario)";
            await using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("UserId", user.RolId);
                cmd.Parameters.AddWithValue("Usuario", user.Usuario);

                await cmd.ExecuteNonQueryAsync();
            }
        }
        //delete
        public async Task Delete(int id)
        {
            string commandText = $"DELETE FROM {user} WHERE ID=(@iduser)";
            await using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("iduser", id);
                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}
