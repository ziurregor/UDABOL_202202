using System;
using Microsoft.EntityFrameworkCore;

using Modelo;

using Microsoft.Extensions.Configuration;

namespace Infrestructura
{
    public class ChatPOSTGREContext : DbContext
    {
        public DbSet<Users> User { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Mensajes> Mensajes { get; set; }

       //protected readonly IConfiguration Configuration;
       //// public ChatPOSTGREContext(IConfiguration configuration)
        //{
           /// Configuration = configuration;
       /// }
         private const string CONNECTION_STRING = "Host=localhost;" + "Port=5050;" + "Username=postgres;" + "Password=postgres;" + "Database=UDA";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(CONNECTION_STRING);
            base.OnConfiguring(options);
        }

}
    
}

