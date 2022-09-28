﻿using System;
using Microsoft.EntityFrameworkCore;
using Modelo;
<<<<<<< HEAD:Proyecto01/Infrestructura/ChatSQLiteContext.cs
=======
//using Npgsql.EntityFrameworkCore;
>>>>>>> infraestructura:Proyecto01/Infrestructura/ChatSQLiteContext.cs

namespace Infrestructura
{
    public class ChatSQLiteContext  : DbContext
    {
        public DbSet<Users> User { get; set; }
        
        public DbSet<Roles> Rol { get; set; }

        public DbSet<Mensajes> Mensaje { get; set;  }
     
        //..
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Chatuser.db");
        }
    }
}

