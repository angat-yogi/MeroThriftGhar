using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MeroThriftGhar.DataAccess.Data;
using MeroThriftGhar.Models;

namespace MeroThriftGhar.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ShippingAddressController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShippingAddressController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customer/ShippingAddress
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ShippingAddresses.Include(s => s.ApplicationUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Customer/ShippingAddress/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shippingAddress = await _context.ShippingAddresses
                .Include(s => s.ApplicationUser)
                .FirstOrDefaultAsync(m => m.ShippingId == id);
            if (shippingAddress == null)
            {
                return NotFound();
            }

            return View(shippingAddress);
        }

        // GET: Customer/ShippingAddress/Create
        public IActionResult Create()
        {
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            return View();
        }

        // POST: Customer/ShippingAddress/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShippingId,ApplicationUserId,Name,StreetAddress,City,State,PostalCode,PhoneNumber")] ShippingAddress shippingAddress)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shippingAddress);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", shippingAddress.ApplicationUserId);
            return View(shippingAddress);
        }

        // GET: Customer/ShippingAddress/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shippingAddress = await _context.ShippingAddresses.FindAsync(id);
            if (shippingAddress == null)
            {
                return NotFound();
            }
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", shippingAddress.ApplicationUserId);
            return View(shippingAddress);
        }

        // POST: Customer/ShippingAddress/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ShippingId,ApplicationUserId,Name,StreetAddress,City,State,PostalCode,PhoneNumber")] ShippingAddress shippingAddress)
        {
            if (id != shippingAddress.ShippingId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shippingAddress);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShippingAddressExists(shippingAddress.ShippingId))
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
            ViewData["ApplicationUserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", shippingAddress.ApplicationUserId);
            return View(shippingAddress);
        }

        // GET: Customer/ShippingAddress/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shippingAddress = await _context.ShippingAddresses
                .Include(s => s.ApplicationUser)
                .FirstOrDefaultAsync(m => m.ShippingId == id);
            if (shippingAddress == null)
            {
                return NotFound();
            }

            return View(shippingAddress);
        }

        // POST: Customer/ShippingAddress/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shippingAddress = await _context.ShippingAddresses.FindAsync(id);
            _context.ShippingAddresses.Remove(shippingAddress);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShippingAddressExists(int id)
        {
            return _context.ShippingAddresses.Any(e => e.ShippingId == id);
        }
    }
}
