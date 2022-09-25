using System;
using Microsoft.EntityFrameworkCore;
using Modelo;
using Npgsql.EntityFrameworkCore;

namespace Infrestructura
{
    public class ChatContext  : DbContext
    {
        public DbSet<Users> User { get; set; }

        public DbSet<Roles> Rol { get; set; }
     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Chatuser.db");
        }
    }
}

