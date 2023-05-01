using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VentasElectronica.Data;
using VentasElectronica.Models;

namespace ElectronicaVentas.Controllers
{
    public class DetalleClienteController : Controller
    {
        private readonly ElectronicaDbContext _context;

        public DetalleClienteController(ElectronicaDbContext context)
        {
            _context = context;
        }

        // GET: DetalleCliente
        public async Task<IActionResult> Index()
        {
              return _context.DetalleCliente != null ? 
                          View(await _context.DetalleCliente.ToListAsync()) :
                          Problem("Entity set 'ElectronicaDbContext.DetalleCliente'  is null.");
        }

        // GET: DetalleCliente/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DetalleCliente == null)
            {
                return NotFound();
            }

            var detalleCliente = await _context.DetalleCliente
                .FirstOrDefaultAsync(m => m.DetalleClienteId == id);
            if (detalleCliente == null)
            {
                return NotFound();
            }

            return View(detalleCliente);
        }

        // GET: DetalleCliente/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DetalleCliente/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DetalleClienteId,clienteId,fecha_nacimiento,mail")] DetalleCliente detalleCliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detalleCliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(detalleCliente);
        }

        // GET: DetalleCliente/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DetalleCliente == null)
            {
                return NotFound();
            }

            var detalleCliente = await _context.DetalleCliente.FindAsync(id);
            if (detalleCliente == null)
            {
                return NotFound();
            }
            return View(detalleCliente);
        }

        // POST: DetalleCliente/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DetalleClienteId,clienteId,fecha_nacimiento,mail")] DetalleCliente detalleCliente)
        {
            if (id != detalleCliente.DetalleClienteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalleCliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetalleClienteExists(detalleCliente.DetalleClienteId))
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
            return View(detalleCliente);
        }

        // GET: DetalleCliente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DetalleCliente == null)
            {
                return NotFound();
            }

            var detalleCliente = await _context.DetalleCliente
                .FirstOrDefaultAsync(m => m.DetalleClienteId == id);
            if (detalleCliente == null)
            {
                return NotFound();
            }

            return View(detalleCliente);
        }

        // POST: DetalleCliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DetalleCliente == null)
            {
                return Problem("Entity set 'ElectronicaDbContext.DetalleCliente'  is null.");
            }
            var detalleCliente = await _context.DetalleCliente.FindAsync(id);
            if (detalleCliente != null)
            {
                _context.DetalleCliente.Remove(detalleCliente);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetalleClienteExists(int id)
        {
          return (_context.DetalleCliente?.Any(e => e.DetalleClienteId == id)).GetValueOrDefault();
        }
    }
}
