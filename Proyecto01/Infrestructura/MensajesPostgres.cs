using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Infrestructura
{
    internal class MensajesPostgres
    {

        //insert
        public async Task Add(Mensajes mensaje)
        {
            string commandText = $"INSERT INTO {Mensajes} (MensajeId, UseridId, Mensaje) VALUES (@MensajeId, @UseridId, @Mensaje)";
            await using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("MensajeId", mensaje.MensajeId);
                cmd.Parameters.AddWithValue("UseridId", mensaje.UseridId);
                cmd.Parameters.AddWithValue("Mensaje", mensaje.Mensaje);
                await cmd.ExecuteNonQueryAsync();
            }
        }
        //delete
        public async Task Delete(int id)
        {
            string commandText = $"DELETE FROM {Mensajes} WHERE ID=(@idmensaje)";
            await using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("idmensaje", id);
                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}
