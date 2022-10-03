using System;
using Microsoft.EntityFrameworkCore;

using Modelo;

//using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Reflection.Emit;


namespace Infrestructura
{
        public class ChatPOSTGREContext : DbContext
        {

        //public ChatPOSTGREContext(DbContextOptions<ChatPOSTGREContext> options)
        //    : base(options)
        //{

        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("User ID =postgres;Password=123456;Server=localhost;Port=5432;Database=UDA;Integrated Security=true;Pooling=true;");
                //"Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
        //                              "User ID =postgres;Password=123456;Server=localhost;Port=5432;Database=UDA;Integrated Security=true;Pooling=true;"

        //}
        public DbSet<Users> Usuarios { get; set; }
            public DbSet<Roles> Roles { get; set; }
            public DbSet<Mensajes> Mensajes { get; set; }
        }
    
}

