using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Modelo;
//using Npgsql.EntityFrameworkCore;

namespace Infrestructura
{
    public class ChatSQLiteContext  : DbContext
    {
        public DbSet<Users> User { get; set; }
        
        public DbSet<Roles> Rol { get; set; }
     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source="+ Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/Chatuser.db");
        }
    }
}

