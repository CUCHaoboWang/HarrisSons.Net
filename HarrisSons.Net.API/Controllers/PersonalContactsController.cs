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
    public class PersonalContactsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PersonalContactsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Personalcontacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personalcontacts>>> GetPersonalcontacts()
        {
            return await _context.Personalcontacts.ToListAsync();
        }

        // GET: api/Personalcontacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Personalcontacts>> GetPersonalcontacts(int id)
        {
            var personalcontacts = await _context.Personalcontacts.FindAsync(id);

            if (personalcontacts == null)
            {
                return NotFound();
            }

            return personalcontacts;
        }

        // PUT: api/Personalcontacts/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonalcontacts(int id, Personalcontacts personalcontacts)
        {
            if (id != personalcontacts.ContactId)
            {
                return BadRequest();
            }

            _context.Entry(personalcontacts).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonalcontactsExists(id))
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

        // POST: api/Personalcontacts
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Personalcontacts>> PostPersonalcontacts(Personalcontacts personalcontacts)
        {
            _context.Personalcontacts.Add(personalcontacts);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersonalcontacts", new { id = personalcontacts.ContactId }, personalcontacts);
        }

        // DELETE: api/Personalcontacts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Personalcontacts>> DeletePersonalcontacts(int id)
        {
            var personalcontacts = await _context.Personalcontacts.FindAsync(id);
            if (personalcontacts == null)
            {
                return NotFound();
            }

            _context.Personalcontacts.Remove(personalcontacts);
            await _context.SaveChangesAsync();

            return personalcontacts;
        }

        private bool PersonalcontactsExists(int id)
        {
            return _context.Personalcontacts.Any(e => e.ContactId == id);
        }
    }
}
