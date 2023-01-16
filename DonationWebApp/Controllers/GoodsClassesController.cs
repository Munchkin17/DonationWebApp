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
    public class GoodsClassesController : Controller
    {
        private readonly GoodsContext _context;

        public GoodsClassesController(GoodsContext context)
        {
            _context = context;
        }

        
        // GET: GoodsClasses
        public async Task<IActionResult> Index()
        {
            return View(await _context.GoodDonation.ToListAsync());
        }

        [Authorize]
        // GET: GoodsClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goodsClass = await _context.GoodDonation
                .FirstOrDefaultAsync(m => m.DonorId == id);
            if (goodsClass == null)
            {
                return NotFound();
            }

            return View(goodsClass);
        }
        [Authorize]
        // GET: GoodsClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GoodsClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DonorId,DateOfDonation,NumberOfItems,Category,AddNewCategory,DescriptionOfItem,Donor")] GoodsClass goodsClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(goodsClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(goodsClass);
        }

        [Authorize]
        // GET: GoodsClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goodsClass = await _context.GoodDonation.FindAsync(id);
            if (goodsClass == null)
            {
                return NotFound();
            }
            return View(goodsClass);
        }

        // POST: GoodsClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DonorId,DateOfDonation,NumberOfItems,Category,AddNewCategory,DescriptionOfItem,Donor")] GoodsClass goodsClass)
        {
            if (id != goodsClass.DonorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(goodsClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GoodsClassExists(goodsClass.DonorId))
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
            return View(goodsClass);
        }

        [Authorize]
        // GET: GoodsClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goodsClass = await _context.GoodDonation
                .FirstOrDefaultAsync(m => m.DonorId == id);
            if (goodsClass == null)
            {
                return NotFound();
            }

            return View(goodsClass);
        }

        // POST: GoodsClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var goodsClass = await _context.GoodDonation.FindAsync(id);
            _context.GoodDonation.Remove(goodsClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GoodsClassExists(int id)
        {
            return _context.GoodDonation.Any(e => e.DonorId == id);
        }
    }
}
