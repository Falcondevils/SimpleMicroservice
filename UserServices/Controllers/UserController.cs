using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserServices.Database;
using UserServices.Database.Entities;

namespace UserServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        DataBaseContext dbcontext;

        public UserController()
        {
            dbcontext = new DataBaseContext();
        }
            
        // GET: api/User
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return dbcontext.Users.ToList();
        }

        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public User Get(int id)
        {
            return dbcontext.Users.Find(id);
        }

        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] User model)
        {
            try
            {
                dbcontext.Users.Add(model);
                dbcontext.SaveChanges();
                return StatusCode(StatusCodes.Status201Created,model);
            }
            catch(Exception exe)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, exe);
            }
        }

       
    }
}
