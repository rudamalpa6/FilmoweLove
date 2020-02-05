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
    public class NewMoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NewMoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NewMovies
        public async Task<IActionResult> Index()
        {
            return View(await _context.NewMovies.ToListAsync());
        }

        // GET: NewMovies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newMovies = await _context.NewMovies
                .FirstOrDefaultAsync(m => m.ID == id);
            if (newMovies == null)
            {
                return NotFound();
            }

            return View(newMovies);
        }

        // GET: NewMovies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NewMovies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nazwa_filmu,Dlugosc_filmu,Data_wydania,okladka,info")] NewMovies newMovies)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newMovies);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(newMovies);
        }

        // GET: NewMovies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newMovies = await _context.NewMovies.FindAsync(id);
            if (newMovies == null)
            {
                return NotFound();
            }
            return View(newMovies);
        }

        // POST: NewMovies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nazwa_filmu,Dlugosc_filmu,Data_wydania,okladka,info")] NewMovies newMovies)
        {
            if (id != newMovies.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newMovies);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewMoviesExists(newMovies.ID))
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
            return View(newMovies);
        }

        // GET: NewMovies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newMovies = await _context.NewMovies
                .FirstOrDefaultAsync(m => m.ID == id);
            if (newMovies == null)
            {
                return NotFound();
            }

            return View(newMovies);
        }

        // POST: NewMovies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var newMovies = await _context.NewMovies.FindAsync(id);
            _context.NewMovies.Remove(newMovies);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewMoviesExists(int id)
        {
            return _context.NewMovies.Any(e => e.ID == id);
        }
    }
}
