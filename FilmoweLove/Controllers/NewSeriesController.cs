using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FilmoweLove.Data;
using FilmoweLove.Models;

namespace FilmoweLove.Controllers
{
    public class NewSeriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NewSeriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NewSeries
        public async Task<IActionResult> Index()
        {
            return View(await _context.NewSeries.ToListAsync());
        }

        // GET: NewSeries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newSeries = await _context.NewSeries
                .FirstOrDefaultAsync(m => m.ID == id);
            if (newSeries == null)
            {
                return NotFound();
            }

            return View(newSeries);
        }

        // GET: NewSeries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NewSeries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nazwa_serialu,ilosc_sezonow,Data_wydania,okladka,info")] NewSeries newSeries)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newSeries);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(newSeries);
        }

        // GET: NewSeries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newSeries = await _context.NewSeries.FindAsync(id);
            if (newSeries == null)
            {
                return NotFound();
            }
            return View(newSeries);
        }

        // POST: NewSeries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nazwa_serialu,ilosc_sezonow,Data_wydania,okladka,info")] NewSeries newSeries)
        {
            if (id != newSeries.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newSeries);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewSeriesExists(newSeries.ID))
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
            return View(newSeries);
        }

        // GET: NewSeries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newSeries = await _context.NewSeries
                .FirstOrDefaultAsync(m => m.ID == id);
            if (newSeries == null)
            {
                return NotFound();
            }

            return View(newSeries);
        }

        // POST: NewSeries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var newSeries = await _context.NewSeries.FindAsync(id);
            _context.NewSeries.Remove(newSeries);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewSeriesExists(int id)
        {
            return _context.NewSeries.Any(e => e.ID == id);
        }
    }
}
