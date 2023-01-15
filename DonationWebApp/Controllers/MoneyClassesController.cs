using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DonationWebApp.Models;

namespace DonationWebApp.Controllers
{
    public class MoneyClassesController : Controller
    {
        private readonly MoneyContext _context;

        public MoneyClassesController(MoneyContext context)
        {
            _context = context;
        }

        // GET: MoneyClasses
        public async Task<IActionResult> Index()
        {
            return View(await _context.MoneyDonation.ToListAsync());
        }

        // GET: MoneyClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moneyClass = await _context.MoneyDonation
                .FirstOrDefaultAsync(m => m.DonorId == id);
            if (moneyClass == null)
            {
                return NotFound();
            }

            return View(moneyClass);
        }

        // GET: MoneyClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MoneyClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DonorId,DateOfDonation,AmountOfDonation,Donor")] MoneyClass moneyClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moneyClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(moneyClass);
        }

        // GET: MoneyClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moneyClass = await _context.MoneyDonation.FindAsync(id);
            if (moneyClass == null)
            {
                return NotFound();
            }
            return View(moneyClass);
        }

        // POST: MoneyClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DonorId,DateOfDonation,AmountOfDonation,Donor")] MoneyClass moneyClass)
        {
            if (id != moneyClass.DonorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moneyClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoneyClassExists(moneyClass.DonorId))
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
            return View(moneyClass);
        }

        // GET: MoneyClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moneyClass = await _context.MoneyDonation
                .FirstOrDefaultAsync(m => m.DonorId == id);
            if (moneyClass == null)
            {
                return NotFound();
            }

            return View(moneyClass);
        }

        // POST: MoneyClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var moneyClass = await _context.MoneyDonation.FindAsync(id);
            _context.MoneyDonation.Remove(moneyClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoneyClassExists(int id)
        {
            return _context.MoneyDonation.Any(e => e.DonorId == id);
        }
    }
}
