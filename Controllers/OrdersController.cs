using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using delishapplication.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;


namespace delishapplication.Controllers
{
    public class OrdersController : Controller
    {
        private readonly delishapplicationContext _context;
        public static List<Order> CurrantOrderHistory;

        public OrdersController(delishapplicationContext context)
        {
            _context = context;
        }
        [Authorize]

        // GET: Orders
        public async Task<IActionResult> Index()
        {

            return View(await _context.Order.ToListAsync());
        }
        [Authorize]
        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order.Include(p => p.DishOrder).ThenInclude(o => o.Dish)
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }
        [Authorize]
        // GET: Orders/Create
        public IActionResult Create()
        {
            ViewBag.chefsList = new SelectList(_context.Chef.ToList(), "ChefID", "ChefUserName");
            ViewData["DishID"] = new SelectList(_context.Dish, "DishID", "DishName");

            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,OrderNumber,OrderDate,ArrivalDate,ClientUserName,TotalPrice")] Order order, int chefID, int[] DishID)
        {
            // ViewBag.listOfDishes = new SelectList(_context.Chef.Where(i => i.ChefID == chefID).ToList().First().MyDishes);
            if (ModelState.IsValid)
            {
                order.DishOrder = new List<DishOrder>();
                foreach (var id in DishID)
                {
                    order.DishOrder.Add(new DishOrder()
                    {
                        DishID = id,
                        Dish = _context.Dish.First(p => p.DishID == id),
                        OrderID = order.OrderID
                    });
                }
                Chef newchef = _context.Chef.First(p => p.ChefID == chefID);
                order.Chef = newchef;

                order.OrderDate = DateTime.Now;
                order.OrderNumber = order.OrderID;

                if (order.DishOrder != null)
                {
                    int sum = 0;
                    foreach (DishOrder d in order.DishOrder)
                    {
                        sum += d.Dish.Price;
                    }

                    order.TotalPrice = sum;
                }
                else
                    order.TotalPrice = 0;

                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }
        [Authorize]
        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,OrderNumber,OrderDate,ArrivalDate,ClientUserName,TotalPrice")] Order order)
        {
            if (id != order.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderID))
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
            return View(order);
        }
        [Authorize]
        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Order.FindAsync(id);
            _context.Order.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Order.Any(e => e.OrderID == id);
        }

        [Authorize(Roles = "Client")]
        public async Task<IActionResult> orderHistory()
        {

            var curr = User as ClaimsPrincipal;
            string hisEmail = curr.Identities.First().Claims.ElementAt(1).Value;

            var orderHistory = _context.Order.Where(k => k.ClientUserName == hisEmail).OrderByDescending(p => p.OrderDate).ToList();
            CurrantOrderHistory = orderHistory;
            return View(orderHistory);
        }

        public IActionResult copyOrder()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> copyOrder(DateTime ArrivalDate)
        {
            Order o = CurrantOrderHistory.First();
            int idOfO = o.OrderID;
            Chef c = o.Chef;
            var currOrder = _context.Order.Find(idOfO);

            //Detach it from the context
            _context.Entry(currOrder).State = EntityState.Detached;

            //add the new values and don't forget to set the primary key value to 0
            currOrder.OrderID = 0;
            currOrder.Chef = c;

            currOrder.OrderDate = DateTime.Now;
            currOrder.ArrivalDate = ArrivalDate;

            //Add it to the context
            _context.Entry(currOrder).State = EntityState.Added;
            //Or add it to tenants list
            _context.Order.Add(currOrder);

            //Create a new record by calling save changes
            _context.SaveChanges();

            return View();
        }


        public IActionResult Search(int OrderID)

        {
            List<Order> orders = new List<Order>();
            foreach (Order o in _context.Order)
                orders.Add(o);

            if (OrderID != null)
            {
                foreach (Order o in _context.Order)
                {
                    if (!(o.OrderID.Equals(OrderID)))

                        orders.Remove(o);
                }
            }
            return View("Index", orders);
        }

        [Authorize(Roles = "Admin")]

        public async Task<ActionResult> SearchByCity(string ClientCity)
        {

            var joinTable = (from o in _context.Order
                             join c in _context.Client
                             on o.ClientUserName equals c.Email
                             where c.City == ClientCity
                             select o);

            return View("Index", await joinTable.ToListAsync());
        }

        public ActionResult GroupByClient()
        {

            var groupbyList = _context.Order.GroupBy(order => order.ClientUserName).ToList();
            ViewBag.groupBy = groupbyList;
            return View();
        }
    }
}
