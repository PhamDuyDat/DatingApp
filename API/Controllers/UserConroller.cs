using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Microsoft.AspNetCore.Mvc;
using API.Entities;
using Microsoft.EntityFrameworkCore;
//  using System.Threading.Tasks;


namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserConroller : ControllerBase

    {
        private readonly DataContext _context;
        public UserConroller(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async  Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync();

        }

        //api/users/3
         [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);

        }
    }
}