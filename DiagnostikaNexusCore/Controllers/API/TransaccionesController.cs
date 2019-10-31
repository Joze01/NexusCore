using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DiagnostikaNexusCore.Models.hlseven;

namespace DiagnostikaNexusCore.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransaccionesController : ControllerBase
    {
        private readonly hl7Context _context;

        public TransaccionesController(hl7Context context)
        {
            _context = context;
        }

        // GET: api/Transacciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transacciones>>> GetTransacciones()
        {
            return await _context.Transacciones.ToListAsync();
        }

        // GET: api/Transacciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Transacciones>> GetTransacciones(int id)
        {
            var transacciones = await _context.Transacciones.FindAsync(id);

            if (transacciones == null)
            {
                return NotFound();
            }

            return transacciones;
        }

        // PUT: api/Transacciones/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransacciones(int id, Transacciones transacciones)
        {
            if (id != transacciones.Indice)
            {
                return BadRequest();
            }

            _context.Entry(transacciones).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransaccionesExists(id))
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

        // POST: api/Transacciones
        [HttpPost]
        public async Task<ActionResult<Transacciones>> PostTransacciones(Transacciones transacciones)
        {
            _context.Transacciones.Add(transacciones);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTransacciones", new { id = transacciones.Indice }, transacciones);
        }

        // DELETE: api/Transacciones/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Transacciones>> DeleteTransacciones(int id)
        {
            var transacciones = await _context.Transacciones.FindAsync(id);
            if (transacciones == null)
            {
                return NotFound();
            }

            _context.Transacciones.Remove(transacciones);
            await _context.SaveChangesAsync();

            return transacciones;
        }

        private bool TransaccionesExists(int id)
        {
            return _context.Transacciones.Any(e => e.Indice == id);
        }


    }
}
