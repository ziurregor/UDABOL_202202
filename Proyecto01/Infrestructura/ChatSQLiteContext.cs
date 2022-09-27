using System;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Infrestructura
{
    public class ChatSQLiteContext  : DbContext
    {
        public DbSet<Users> User { get; set; }

        public DbSet<Roles> Rol { get; set; }
     
        //..
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Chatuser.db");
        }
    }
}

