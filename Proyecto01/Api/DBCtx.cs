using Modelo;
using Microsoft.EntityFrameworkCore;
namespace Api
{
    public class DBCtx : DbContext
    {
        public DBCtx(DbContextOptions<DBCtx> options) : base(options)
        {
        }

        public DbSet<Mensajes> Mensajec { get; set; }
    }
}
