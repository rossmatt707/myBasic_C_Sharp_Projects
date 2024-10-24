using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private readonly InsureeContext _context;

        public InsureeController(InsureeContext context)
        {
            _context = context;
        }

        // GET: Insurees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insurees.ToListAsync());
        }

        // GET: Insurees/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // GET: Insurees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Insurees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,Dui,SpeedingTickets,Coverages")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Id = Guid.NewGuid();
                insuree.Quote = CalculateQuote(insuree); // Calculate the quote
                _context.Add(insuree);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // Method to calculate the quote based on the user's input
        private decimal CalculateQuote(Insuree insuree)
        {
            decimal baseRate = 50m; // Base rate of $50
            decimal total = baseRate;

            // Age-based adjustments
            int age = DateTime.Now.Year - insuree.DateOfBirth?.Year ?? 0;
            if (age <= 18) total += 100;
            else if (age >= 19 && age <= 25) total += 50;
            else if (age > 25) total += 25;

            // Car year adjustments
            if (insuree.CarYear < 2000) total += 25;
            else if (insuree.CarYear > 2015) total += 25;

            // Car make and model adjustments
            if (insuree.CarMake?.ToLower() == "porsche")
            {
                total += 25;
                if (insuree.CarModel?.ToLower() == "911 carrera") total += 25;
            }

            // Speeding tickets
            if (insuree.SpeedingTickets.HasValue)
            {
                total += insuree.SpeedingTickets.Value * 10;
            }

            // DUI adjustment
            if (insuree.Dui)
            {
                total *= 1.25m; // Add 25%
            }

            // Coverage types adjustments based on the selected coverages
            foreach (var coverage in insuree.Coverages)
            {
                switch (coverage) // Add a percentage based on the coverage type
                {
                    case CoverageType.FullCoverage:
                        total *= 1.5m; // Add 50%
                        break;
                    case CoverageType.Collision:
                        total *= 1.2m; // Add 20%
                        break;
                    case CoverageType.Comprehensive:
                        total *= 1.1m; // Add 10%
                        break;
                    case CoverageType.PersonalInjuryProtection:
                        total *= 1.15m; // Add 15%
                        break;
                    case CoverageType.UninsuredMotorist:
                        total *= 1.05m; // Add 5%
                        break;
                }
            }

            return total;
        }

        // GET: Insurees/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree == null)
            {
                return NotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,Dui,SpeedingTickets,Coverages")] Insuree insuree)
        {
            if (id != insuree.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    insuree.Quote = CalculateQuote(insuree); // Recalculate quote on edit
                    _context.Update(insuree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsureeExists(insuree.Id))
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
            return View(insuree);
        }

        // GET: Insurees/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // POST: Insurees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree != null)
            {
                _context.Insurees.Remove(insuree);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsureeExists(Guid id)
        {
            return _context.Insurees.Any(e => e.Id == id);
        }

        // Admin view to display all Insurees with their quotes
        public async Task<IActionResult> Admin()
        {
            var insurees = await _context.Insurees.ToListAsync();
            return View(insurees);
        }
    }
}
