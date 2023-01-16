using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DonationWebApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace DonationWebApp.Controllers
{
    public class DisasterClassesController : Controller
    {
        private readonly DisasterContext _context;

        public DisasterClassesController(DisasterContext context)
        {
            _context = context;
        }
        [Authorize]
        // GET: DisasterClasses
        public async Task<IActionResult> Index()
        {
            return View(await _context.Disaster.ToListAsync());
        }

        [Authorize]
        // GET: DisasterClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disasterClass = await _context.Disaster
                .FirstOrDefaultAsync(m => m.DisasterId == id);
            if (disasterClass == null)
            {
                return NotFound();
            }

            return View(disasterClass);
        }

        [Authorize]
        // GET: DisasterClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DisasterClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DisasterId,DisasterName,StartDate,EndDate,Location,Description,RequiredAidTypes")] DisasterClass disasterClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(disasterClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(disasterClass);
        }

        [Authorize]
        // GET: DisasterClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disasterClass = await _context.Disaster.FindAsync(id);
            if (disasterClass == null)
            {
                return NotFound();
            }
            return View(disasterClass);
        }

        // POST: DisasterClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DisasterId,DisasterName,StartDate,EndDate,Location,Description,RequiredAidTypes")] DisasterClass disasterClass)
        {
            if (id != disasterClass.DisasterId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(disasterClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DisasterClassExists(disasterClass.DisasterId))
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
            return View(disasterClass);
        }

        [Authorize]
        // GET: DisasterClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disasterClass = await _context.Disaster
                .FirstOrDefaultAsync(m => m.DisasterId == id);
            if (disasterClass == null)
            {
                return NotFound();
            }

            return View(disasterClass);
        }

        // POST: DisasterClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var disasterClass = await _context.Disaster.FindAsync(id);
            _context.Disaster.Remove(disasterClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DisasterClassExists(int id)
        {
            return _context.Disaster.Any(e => e.DisasterId == id);
        }
    }
}
