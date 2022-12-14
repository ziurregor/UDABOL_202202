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

        public DbSet<Mensajes> Mensaje { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=/Users/rogerruizescobar/Documents/UDABOL/UDABOL_202202/Chatuser.db");
            //Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "/Chatuser.db");
        }
    }
}

