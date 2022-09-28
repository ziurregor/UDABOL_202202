using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Infrestructura
{
    internal class RolesPostges
    {
        
        //insert
        public async Task Add(Roles rol)
        {
            string commandText = $"INSERT INTO {Roles} (RolId, Nombre) VALUES (@RolId, @Nombre)";
            await using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("RolId", rol.RolId);
                cmd.Parameters.AddWithValue("Nombre", rol.Nombre);

                await cmd.ExecuteNonQueryAsync();
            }
        }
        //delete
        public async Task Delete(int id)
        {
            string commandText = $"DELETE FROM {Roles} WHERE ID=(@idrol)";
            await using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("idrol", id);
                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}
