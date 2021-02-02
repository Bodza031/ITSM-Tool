using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            return _context.AppUser.ToList();
        }

        // api/Contacts/3
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.AppUser.FindAsync(id);
        }
        
    }
}
