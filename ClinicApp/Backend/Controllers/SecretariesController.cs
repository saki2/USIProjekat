using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.Data;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecretariesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SecretariesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Secretaries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Secretary>>> GetSecretaries()
        {
            return await _context.Secretaries.ToListAsync();
        }

        // GET: api/Secretaries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Secretary>> GetSecretary(int id)
        {
            var secretary = await _context.Secretaries.FindAsync(id);

            if (secretary == null)
            {
                return NotFound();
            }

            return secretary;
        }

        // PUT: api/Secretaries/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSecretary(int id, Secretary secretary)
        {
            if (id != secretary.Id)
            {
                return BadRequest();
            }

            _context.Entry(secretary).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SecretaryExists(id))
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

        // POST: api/Secretaries
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Secretary>> PostSecretary(Secretary secretary)
        {
            _context.Secretaries.Add(secretary);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSecretary", new { id = secretary.Id }, secretary);
        }

        // DELETE: api/Secretaries/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Secretary>> DeleteSecretary(int id)
        {
            var secretary = await _context.Secretaries.FindAsync(id);
            if (secretary == null)
            {
                return NotFound();
            }

            _context.Secretaries.Remove(secretary);
            await _context.SaveChangesAsync();

            return secretary;
        }

        private bool SecretaryExists(int id)
        {
            return _context.Secretaries.Any(e => e.Id == id);
        }
    }
}
