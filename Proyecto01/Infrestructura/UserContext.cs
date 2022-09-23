using System;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Infrestructura
{
    public class UserContext  : DbContext
    {
        public DbSet<Users> User { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Chatuser.db");
        }
    }
}

