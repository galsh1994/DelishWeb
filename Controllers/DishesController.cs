using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using delishapplication.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace delishapplication.Controllers
{
    public class DishesController : Controller
    {
        private readonly delishapplicationContext _context;

        public DishesController(delishapplicationContext context)
        {
            _context = context;
        }
        //[Authorize(Roles = "Admin")]
        // GET: Dishes
        public async Task<IActionResult> Index()
        {
            ViewBag.AllTheDishes = _context.Dish.ToList();
            
            return View(await _context.Dish.ToListAsync());
        }
        [Authorize]
        // GET: Dishes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dish = await _context.Dish
                .FirstOrDefaultAsync(m => m.DishID == id);
            if (dish == null)
            {
                return NotFound();
            }

            return View(dish);
        }

        [Authorize]
        // GET: Dishes/Create
        public IActionResult Create()
        {
            ViewBag.chefsList = new SelectList(_context.Chef.ToList(), "ChefID", "ChefUserName");
            return View();
        }

        // POST: Dishes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DishID,DishName,Price,Spicy,Vegan,Kosher,Cuisine,Type,Description,PhotoLink")] Dish dish, int chefID)
        {
            dish.Chef = _context.Chef.First(p => p.ChefID == chefID);
            dish.Popularity = 0;
            if (ModelState.IsValid)
            {
                _context.Add(dish);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dish);
        }
        // GET: Dishes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dish = await _context.Dish.FindAsync(id);
            if (dish == null)
            {
                return NotFound();
            }
            return View(dish);
        }

        // POST: Dishes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DishID,DishName,Price,Spicy,Vegan,Description,PhotoLink")] Dish dish)
        {
            if (id != dish.DishID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dish);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DishExists(dish.DishID))
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
            return View(dish);
        }

        // GET: Dishes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dish = await _context.Dish
                .FirstOrDefaultAsync(m => m.DishID == id);
            if (dish == null)
            {
                return NotFound();
            }

            return View(dish);
        }

        // POST: Dishes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dish = await _context.Dish.FindAsync(id);
            _context.Dish.Remove(dish);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DishExists(int id)
        {
            return _context.Dish.Any(e => e.DishID == id);
        }
        [Authorize]
        public async Task<ActionResult> Search(string term)
       {
            var query = from p in _context.Dish
                        where p.DishName.Contains(term)
                        select new { id = p.DishID, label = p.DishName, value = p.DishID };
            return Json(await query.ToListAsync());
        }
        [Authorize]
        public async Task<ActionResult> SearchByFeature(string DishName, string Kosher, string Price)
        {
            List<Dish> showList = new List<Dish>();


            bool boolKosher = true;
            if (Kosher == "0") boolKosher = false;
            else boolKosher = true;
            if (DishName == null) DishName = "";
            var intPrice = Int32.MaxValue;

            if (Price != null) intPrice= int.Parse(Price);


            var joinTable = (from d in _context.Dish
                             join c in _context.Chef
                             on d.Chef.ChefID equals c.ChefID
                             where d.Price <= intPrice && d.DishName == DishName && c.Kosher == boolKosher
                             select d);

            return View("Index", await joinTable.ToListAsync());
        }
    }
}
