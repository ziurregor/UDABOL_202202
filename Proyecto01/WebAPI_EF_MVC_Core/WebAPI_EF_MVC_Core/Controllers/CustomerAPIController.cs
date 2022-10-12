using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_EF_MVC_Core.Models;

namespace WebAPI_EF_MVC_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAPIController : ControllerBase
    {
        private DBCtx Context { get; }

        public CustomerAPIController(DBCtx _context)
        {
            this.Context = _context;
        }

        [Route("GetCustomers")]
        [HttpGet]
        public List<Users> GetCustomers(string name)
        {
            return null;//(from c in this.Context.Customers.Take(10)
                    //where c.ContactName.StartsWith(name) || string.IsNullOrEmpty(name)
                    //select c).ToList();
        }
    }
}
