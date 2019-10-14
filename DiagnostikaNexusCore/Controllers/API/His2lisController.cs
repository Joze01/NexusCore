using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DiagnostikaNexusCore.Models.Openf;

namespace DiagnostikaNexusCore.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class His2lisController : ControllerBase
    {
        private readonly openfContext _context;

        public His2lisController(openfContext context)
        {
            _context = context;
        }

        // GET: api/His2lis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<His2lis>>> GetHis2lis()
        {
            return await _context.His2lis.ToListAsync();
        }

        // GET: api/His2lis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<His2lis>> GetHis2lis(decimal id)
        {
            var his2lis = await _context.His2lis.FindAsync(id);

            if (his2lis == null)
            {
                return NotFound();
            }

            return his2lis;
        }

        // PUT: api/His2lis/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHis2lis(decimal id, His2lis his2lis)
        {
            if (id != his2lis.Indice)
            {
                return BadRequest();
            }

            _context.Entry(his2lis).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!His2lisExists(id))
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

        // POST: api/His2lis
        [HttpPost]
        public async Task<ActionResult<His2lis>> PostHis2lis(His2lis his2lis)
        {
            _context.His2lis.Add(his2lis);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHis2lis", new { id = his2lis.Indice }, his2lis);
        }

        // DELETE: api/His2lis/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<His2lis>> DeleteHis2lis(decimal id)
        {
            var his2lis = await _context.His2lis.FindAsync(id);
            if (his2lis == null)
            {
                return NotFound();
            }

            _context.His2lis.Remove(his2lis);
            await _context.SaveChangesAsync();

            return his2lis;
        }

        private bool His2lisExists(decimal id)
        {
            return _context.His2lis.Any(e => e.Indice == id);
        }
    }
}
