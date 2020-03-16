using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HarrisSons.Net.API.Models;

namespace HarrisSons.Net.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessContactsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BusinessContactsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Businesscontacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Businesscontacts>>> GetBusinesscontacts()
        {
            return await _context.Businesscontacts.ToListAsync();
        }

        // GET: api/Businesscontacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Businesscontacts>> GetBusinesscontacts(int id)
        {
            var businesscontacts = await _context.Businesscontacts.FindAsync(id);

            if (businesscontacts == null)
            {
                return NotFound();
            }

            return businesscontacts;
        }

        // PUT: api/Businesscontacts/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBusinesscontacts(int id, Businesscontacts businesscontacts)
        {
            if (id != businesscontacts.ContactId)
            {
                return BadRequest();
            }

            _context.Entry(businesscontacts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusinesscontactsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Businesscontacts
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Businesscontacts>> PostBusinesscontacts(Businesscontacts businesscontacts)
        {
            _context.Businesscontacts.Add(businesscontacts);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBusinesscontacts", new { id = businesscontacts.ContactId }, businesscontacts);
        }

        // DELETE: api/Businesscontacts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Businesscontacts>> DeleteBusinesscontacts(int id)
        {
            var businesscontacts = await _context.Businesscontacts.FindAsync(id);
            if (businesscontacts == null)
            {
                return NotFound();
            }

            _context.Businesscontacts.Remove(businesscontacts);
            await _context.SaveChangesAsync();

            return businesscontacts;
        }

        private bool BusinesscontactsExists(int id)
        {
            return _context.Businesscontacts.Any(e => e.ContactId == id);
        }
    }
}
