using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Covaccin.orm;

namespace Covaccin.web.Controllers
{
    public class TypeVaccinsController : Controller
    {
        private readonly Contexte _context = new Contexte();
        /*
        public TypeVaccinsController(Contexte context)
        {
            _context = context;
        }*/

        // GET: TypeVaccins
        public async Task<IActionResult> Index()
        {
            return View(await _context.TypeVaccins.ToListAsync());
        }

        // GET: TypeVaccins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeVaccin = await _context.TypeVaccins
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeVaccin == null)
            {
                return NotFound();
            }

            return View(typeVaccin);
        }

        // GET: TypeVaccins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TypeVaccins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,typeVaccin")] TypeVaccin typeVaccin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(typeVaccin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(typeVaccin);
        }

        // GET: TypeVaccins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeVaccin = await _context.TypeVaccins.FindAsync(id);
            if (typeVaccin == null)
            {
                return NotFound();
            }
            return View(typeVaccin);
        }

        // POST: TypeVaccins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,typeVaccin")] TypeVaccin typeVaccin)
        {
            if (id != typeVaccin.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(typeVaccin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TypeVaccinExists(typeVaccin.Id))
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
            return View(typeVaccin);
        }

        // GET: TypeVaccins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var typeVaccin = await _context.TypeVaccins
                .FirstOrDefaultAsync(m => m.Id == id);
            if (typeVaccin == null)
            {
                return NotFound();
            }

            return View(typeVaccin);
        }

        // POST: TypeVaccins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var typeVaccin = await _context.TypeVaccins.FindAsync(id);
            _context.TypeVaccins.Remove(typeVaccin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TypeVaccinExists(int id)
        {
            return _context.TypeVaccins.Any(e => e.Id == id);
        }
    }
}
