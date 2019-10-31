using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestProject.Models;

namespace TestProject
{
    public class TransaccionesController : Controller
    {
        private readonly hl7Context _context;

        public TransaccionesController(hl7Context context)
        {
            _context = context;
        }

        // GET: Transacciones
        public async Task<IActionResult> Index()
        {
            var hl7Context = _context.Transacciones.Include(t => t.EstadoNavigation);
            return View(await hl7Context.ToListAsync());
        }

        // GET: Transacciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transacciones = await _context.Transacciones
                .Include(t => t.EstadoNavigation)
                .FirstOrDefaultAsync(m => m.Indice == id);
            if (transacciones == null)
            {
                return NotFound();
            }

            return View(transacciones);
        }

        // GET: Transacciones/Create
        public IActionResult Create()
        {
            ViewData["Estado"] = new SelectList(_context.EstadosTransacciones, "Idestado", "Idestado");
            return View();
        }

        // POST: Transacciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Indice,Peticion,Respuesta,Estado,Fecha,Pruebas,Completas,Orden,Siapsid,Orc,Ox")] Transacciones transacciones)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transacciones);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Estado"] = new SelectList(_context.EstadosTransacciones, "Idestado", "Idestado", transacciones.Estado);
            return View(transacciones);
        }

        // GET: Transacciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transacciones = await _context.Transacciones.FindAsync(id);
            if (transacciones == null)
            {
                return NotFound();
            }
            ViewData["Estado"] = new SelectList(_context.EstadosTransacciones, "Idestado", "Idestado", transacciones.Estado);
            return View(transacciones);
        }

        // POST: Transacciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Indice,Peticion,Respuesta,Estado,Fecha,Pruebas,Completas,Orden,Siapsid,Orc,Ox")] Transacciones transacciones)
        {
            if (id != transacciones.Indice)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transacciones);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransaccionesExists(transacciones.Indice))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Estado"] = new SelectList(_context.EstadosTransacciones, "Idestado", "Idestado", transacciones.Estado);
            return View(transacciones);
        }

        // GET: Transacciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transacciones = await _context.Transacciones
                .Include(t => t.EstadoNavigation)
                .FirstOrDefaultAsync(m => m.Indice == id);
            if (transacciones == null)
            {
                return NotFound();
            }

            return View(transacciones);
        }

        // POST: Transacciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transacciones = await _context.Transacciones.FindAsync(id);
            _context.Transacciones.Remove(transacciones);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransaccionesExists(int id)
        {
            return _context.Transacciones.Any(e => e.Indice == id);
        }
    }
}
