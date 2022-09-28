using System;
using Microsoft.EntityFrameworkCore;

using Modelo;

using Microsoft.Extensions.Configuration;

namespace Infrestructura
{
    public class ChatPOSTGREContext : DbContext
    {

        private const string CONNECTION_STRING = "Host=localhost;" + 
                "Port=5432;" +
                "Username=postgres;" +
                "Password=123456;" +
                "Database=UDA";
        //protected readonly IConfiguration Configuration;
        //public ChatPOSTGREContext(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(CONNECTION_STRING);
            base.OnConfiguring(options);
        }

        public DbSet<Users> User { get; set; }
        public DbSet<Roles> Role { get; set; }
        public DbSet<Mensajes> Mensaje { get; set; }

    }
    
}

