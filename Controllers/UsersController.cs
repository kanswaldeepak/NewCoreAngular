using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext __context;
        public UsersController(DataContext _context)
        {
            __context = _context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetAppUsers() 
        { 
            var result = await __context.AppUsers.ToListAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetAppUsers(int id) 
        { 
            var result = await __context.AppUsers.Where(x=>x.Id == id).FirstOrDefaultAsync();
            return Ok(result);
        }



    }
}