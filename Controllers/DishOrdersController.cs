using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using delishapplication.Models;

namespace delishapplication.Controllers
{
    public class DishOrdersController : Controller
    {
        private readonly delishapplicationContext _context;

        public DishOrdersController(delishapplicationContext context)
        {
            _context = context;
        }

        // GET: DishOrders
        public async Task<IActionResult> Index()
        {
            var delishapplicationContext = _context.DishOrder.Include(d => d.Dish).Include(d => d.Order);
            return View(await delishapplicationContext.ToListAsync());
        }

        // GET: DishOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dishOrder = await _context.DishOrder
                .Include(d => d.Dish)
                .Include(d => d.Order)
                .FirstOrDefaultAsync(m => m.DishID == id);
            if (dishOrder == null)
            {
                return NotFound();
            }

            return View(dishOrder);
        }

        // GET: DishOrders/Create
        public IActionResult Create()
        {
            ViewData["DishID"] = new SelectList(_context.Dish, "DishID", "DishName");
            ViewData["OrderID"] = new SelectList(_context.Set<Order>(), "OrderID", "OrderID");
            return View();
        }

        // POST: DishOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DishID,OrderID")] DishOrder dishOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dishOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DishID"] = new SelectList(_context.Dish, "DishID", "DishName", dishOrder.DishID);
            ViewData["OrderID"] = new SelectList(_context.Set<Order>(), "OrderID", "OrderID", dishOrder.OrderID);
            return View(dishOrder);
        }

        // GET: DishOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dishOrder = await _context.DishOrder.FindAsync(id);
            if (dishOrder == null)
            {
                return NotFound();
            }
            ViewData["DishID"] = new SelectList(_context.Dish, "DishID", "DishName", dishOrder.DishID);
            ViewData["OrderID"] = new SelectList(_context.Set<Order>(), "OrderID", "OrderID", dishOrder.OrderID);
            return View(dishOrder);
        }

        // POST: DishOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DishID,OrderID")] DishOrder dishOrder)
        {
            if (id != dishOrder.DishID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dishOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DishOrderExists(dishOrder.DishID))
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
            ViewData["DishID"] = new SelectList(_context.Dish, "DishID", "DishName", dishOrder.DishID);
            ViewData["OrderID"] = new SelectList(_context.Set<Order>(), "OrderID", "OrderID", dishOrder.OrderID);
            return View(dishOrder);
        }

        // GET: DishOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dishOrder = await _context.DishOrder
                .Include(d => d.Dish)
                .Include(d => d.Order)
                .FirstOrDefaultAsync(m => m.DishID == id);
            if (dishOrder == null)
            {
                return NotFound();
            }

            return View(dishOrder);
        }

        // POST: DishOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dishOrder = await _context.DishOrder.FindAsync(id);
            _context.DishOrder.Remove(dishOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DishOrderExists(int id)
        {
            return _context.DishOrder.Any(e => e.DishID == id);
        }

     
    }
}
