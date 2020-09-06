//using System.Data.Entity;
//using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using delishapplication.Models;
using Microsoft.AspNetCore.Authentication;
using AuthenticationProperties = Microsoft.AspNetCore.Authentication.AuthenticationProperties;
using System.Threading;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace delishapplication.Controllers
{
    public class ChefsController : Controller
    {
        private readonly delishapplicationContext _context;
        public static int idChef;
     

        public ChefsController(delishapplicationContext context)
        {
            _context = context;
        }

        public IActionResult MyTable()

        {
            
            Chef[] bestChefs = _context.Chef
                 .OrderByDescending(p => p.Popularity).ToArray();

            ViewBag.ourarr = bestChefs;
            return View(bestChefs);

        }

        [Authorize]
        // GET: Chefs
        public async Task<IActionResult> Index()
        {
            //do not delete! related to order- groupBy
            var groupbyList = _context.Chef.ToList();
            ViewBag.AllTheChefs = groupbyList;
            // until here

            return View(await _context.Chef.ToListAsync());
        }
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Chef.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                SignInAsync(user);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }


        private async Task SignInAsync(Chef user)
        {
            
                var claims = new List<Claim>
        {
            new Claim ("UserName", user.ChefUserName),
            new Claim ("FullName", user.FirstName+" "+user.LastName),
            new Claim ("Type", user.Type.ToString()),
            new Claim (ClaimTypes.Role, user.Type.ToString()),

        };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties { };
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), authProperties);

            }

        
        public async Task<IActionResult> Logout()
        {
             await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
             return RedirectToAction("Login");
             
               
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        
        public async Task<IActionResult> Register(string ChefUserName, string FirstName, string LastName, string PhotoLink, string PhoneNumber, string Email, string
            Password, int Experience, string City, bool Kosher, string Cuisine)
        {

            Chef NewChef = new Chef()
            {
                ChefUserName = ChefUserName,
                FirstName = FirstName,
                LastName = LastName,
                PhoneNumber = PhoneNumber,
                Email = Email,
                Password = Password,
                Experience = Experience,
                City = City,
                Kosher = Kosher,
                Type = ChefType.Chef,
                Cuisine = Cuisine,
                PhotoLink= PhotoLink
            };
            _context.Add(NewChef);
            await _context.SaveChangesAsync();
            SignInAsync(NewChef);
            return RedirectToAction("Index", "Home");
        }
        // GET: Chefs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            //do not delete! related to order- groupBy
            ViewBag.ChefsDishes = _context.Dish.Where(c => c.Chef.ChefID == id).ToList();
            // until here

            if (id == null)
            {
                return NotFound();
            }

            var chef = await _context.Chef.Include(p=>p.MyDishes)
                .FirstOrDefaultAsync(m => m.ChefID == id);
            if (chef == null)
            {
                return NotFound();
            }

            return View(chef);
        }

        // GET: Chefs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Chefs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ChefID,ChefUserName,FirstName,LastName,PhoneNumber,Email,Password,Experience,City,Kosher,Cuisine")] Chef chef)
        {
            if (ModelState.IsValid)
            {
                chef.Popularity = 0;
                _context.Add(chef);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chef);
        }

        // GET: Chefs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chef = await _context.Chef.FindAsync(id);
            if (chef == null)
            {
                return NotFound();
            }
            return View(chef);
        }

        // POST: Chefs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ChefID,ChefUserName,FirstName,LastName,PhoneNumber,Email,Password,Experience,City,Kosher,Cuisine")] Chef chef)
        {
            if (id != chef.ChefID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chef);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChefExists(chef.ChefID))
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
            return View(chef);
        }

        // GET: Chefs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chef = await _context.Chef
                .FirstOrDefaultAsync(m => m.ChefID == id);
            if (chef == null)
            {
                return NotFound();
            }

            return View(chef);
        }

        // POST: Chefs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chef = await _context.Chef.FindAsync(id);
            _context.Chef.Remove(chef);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChefExists(int id)
        {
            return _context.Chef.Any(e => e.ChefID == id);
        }

     
        public IActionResult Search(string chefName, string cuisine, string city)

        {
            List<Chef> chefs = new List<Chef>();
            foreach (Chef c in _context.Chef)
            {
                chefs.Add(c);
            }

            if (chefName != null) 
            {
                string[] fullName = chefName.Split(" ");
                if (fullName.Length == 2)
                {
                    foreach (Chef c in _context.Chef)
                    {
                        if (!(c.FirstName.ToLower().Contains(fullName[0].ToLower())))
                        {
                            chefs.Remove(c);
                        }
                        if (!(c.LastName.ToLower().Contains(fullName[1].ToLower())))
                        {
                            chefs.Remove(c);
                        }
                    }
                }
                else
                {
                    foreach (Chef c in _context.Chef)

                        if (!(c.LastName.ToLower().Contains(fullName[0]))
                            && !(c.FirstName.ToLower().Contains(fullName[0])))
                        {
                            chefs.Remove(c);
                        }
                }
            }
            if (cuisine != null)
            {
                foreach (Chef c in _context.Chef)

                    if (!c.Cuisine.ToLower().Equals(cuisine.ToLower()))
                    {
                        chefs.Remove(c);
                    }
            }
            if (city != null)// !City.Equals(""))        
            {
                foreach (Chef c in _context.Chef)

                    if (!c.City.ToLower().Equals(city.ToLower()))
                    {
                        chefs.Remove(c);
                    }
            }
            ViewBag.AllTheChefs = chefs;
            return View("Index", chefs);
        }
        [Authorize(Roles = "Client")]
        public async Task<IActionResult> CreateAnOrder(int id)
        {
            ViewBag.mydishes= new SelectList(_context.Dish.Where(c=>c.Chef.ChefID==id).ToList() , "DishID", "DishName");
            idChef = id;
            _context.Chef.First(c => c.ChefID == id).Popularity = _context.Chef.First(c => c.ChefID == id).Popularity + 1;
            await _context.SaveChangesAsync();
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Client")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAnOrder([Bind("OrderID,OrderNumber,OrderDate,ArrivalDate,ClientUserName,TotalPrice")] Order order, DateTime ArrivalDate , int[] DishID)
        {
             
            var curr = User as System.Security.Claims.ClaimsPrincipal;
            string hisEmail= curr.Identities.First().Claims.ElementAt(1).Value;
        
           
            
            order.ClientUserName = hisEmail;
            order.OrderNumber = order.OrderID;

            if (ModelState.IsValid)
            {
              
                order.DishOrder = new List<DishOrder>();
                int firstID = DishID.ElementAt(0);
                foreach (var id in DishID)
                {
                    order.DishOrder.Add(new DishOrder()
                    { 
                        DishID = id,
                        Dish = _context.Dish.First(p => p.DishID == id),
                        OrderID = order.OrderID,
                        
                    });
                  
                }

                foreach (var thisID in DishID)
                {
                    Dish d = _context.Dish.First(p => p.DishID == thisID);
                    d.Popularity = d.Popularity + 1;
                    await _context.SaveChangesAsync();
                }
           
                Chef f = _context.Chef.First(p => p.ChefID == idChef);
                order.Chef = f;
                order.OrderDate = DateTime.Now;


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

        [Authorize(Roles = "Chef,Admin")]
        public IActionResult AddDishFromChef()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> AddDishFromChef([Bind("DishID,DishName,Price,Spicy,Vegan,Kosher,Cuisine,Type,Description,PhotoLink")] Dish dish, int chefID)
        {
            var curr = User as ClaimsPrincipal;
            string hisUserName = curr.Identities.First().Claims.ElementAt(0).Value;
         
            dish.Chef = _context.Chef.First(p => p.ChefUserName == hisUserName);
            dish.Popularity = 0;
            if (ModelState.IsValid)
            {
                _context.Add(dish);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dish);
        }
    }
}
