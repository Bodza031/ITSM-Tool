using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController : ControllerBase
    {
        private readonly DataContext _context;

        public ContactsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Contact>> GetUsers()
        {
            return _context.Contacts.ToList();
        }

        // api/Contacts/3
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetUser(int id)
        {
            return await _context.Contacts.FindAsync(id);
        }
        
    }
}
