using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ElectronicaVentas.Models;
using VentasElectronica.Data;

namespace ElectronicaVentas.Controllers
{
    public class DetalleVentaController : Controller
    {
        private readonly ElectronicaDbContext _context;

        public DetalleVentaController(ElectronicaDbContext context)
        {
            _context = context;
        }

        // GET: DetalleVenta
        public async Task<IActionResult> Index()
        {
              return _context.DetalleVenta != null ? 
                          View(await _context.DetalleVenta.ToListAsync()) :
                          Problem("Entity set 'ElectronicaDbContext.DetalleVenta'  is null.");
        }

        // GET: DetalleVenta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DetalleVenta == null)
            {
                return NotFound();
            }

            var detalleVenta = await _context.DetalleVenta
                .FirstOrDefaultAsync(m => m.DetalleVentaId == id);
            if (detalleVenta == null)
            {
                return NotFound();
            }

            return View(detalleVenta);
        }

        // GET: DetalleVenta/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DetalleVenta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DetalleVentaId,ventaId,productoId")] DetalleVenta detalleVenta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detalleVenta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(detalleVenta);
        }

        // GET: DetalleVenta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DetalleVenta == null)
            {
                return NotFound();
            }

            var detalleVenta = await _context.DetalleVenta.FindAsync(id);
            if (detalleVenta == null)
            {
                return NotFound();
            }
            return View(detalleVenta);
        }

        // POST: DetalleVenta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DetalleVentaId,ventaId,productoId")] DetalleVenta detalleVenta)
        {
            if (id != detalleVenta.DetalleVentaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalleVenta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetalleVentaExists(detalleVenta.DetalleVentaId))
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
            return View(detalleVenta);
        }

        // GET: DetalleVenta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DetalleVenta == null)
            {
                return NotFound();
            }

            var detalleVenta = await _context.DetalleVenta
                .FirstOrDefaultAsync(m => m.DetalleVentaId == id);
            if (detalleVenta == null)
            {
                return NotFound();
            }

            return View(detalleVenta);
        }

        // POST: DetalleVenta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DetalleVenta == null)
            {
                return Problem("Entity set 'ElectronicaDbContext.DetalleVenta'  is null.");
            }
            var detalleVenta = await _context.DetalleVenta.FindAsync(id);
            if (detalleVenta != null)
            {
                _context.DetalleVenta.Remove(detalleVenta);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetalleVentaExists(int id)
        {
          return (_context.DetalleVenta?.Any(e => e.DetalleVentaId == id)).GetValueOrDefault();
        }
    }
}
