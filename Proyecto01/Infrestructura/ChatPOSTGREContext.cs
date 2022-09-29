using System;
using Microsoft.EntityFrameworkCore;

using Modelo;

using Microsoft.Extensions.Configuration;

namespace Infrestructura
{
    public class ChatPOSTGREContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public ChatPOSTGREContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("MyWebApiConection"));
        }

        public DbSet<Users> User { get; set; }
    ////public DbSet<Roles> Roles { get; set; }
    ////protected override void OnModelCreating(ModelBuilder modelBuilder)
    ////{

    ////}

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    optionsBuilder.UseNpgsql("ConnectionStrings");
    //    base.OnConfiguring(optionsBuilder);
    //}
}
    
}

