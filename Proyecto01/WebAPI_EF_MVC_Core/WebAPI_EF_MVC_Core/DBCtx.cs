using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_EF_MVC_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI_EF_MVC_Core
{
    public class DBCtx : DbContext
    {
        public DBCtx(DbContextOptions<DBCtx> options) : base(options)
        {
        }

        public DbSet<Users> Customers { get; set; }
    }
}
