using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Mvc;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.EntityFrameworkCore;
using delishapplication.Models;
using System.Security.Claims;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Authentication;
using AuthenticationProperties = Microsoft.AspNetCore.Authentication.AuthenticationProperties;
using Microsoft.AspNetCore.Http;

namespace delishapplication.Controllers
{
    public class ClientsController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly delishapplicationContext _context;

        public ClientsController(delishapplicationContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Admin")]
        // GET: Clients
        public async Task<IActionResult> Index()
        {
            //do not delete! related to order- groupBy
            var groupbyList = _context.Chef.ToList();
            ViewBag.AllTheChefs = groupbyList;
            // until here
            return View(await _context.Client.ToListAsync());
        }
        [Authorize(Roles = "Admin")]
        // GET: Clients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Client
                .FirstOrDefaultAsync(m => m.ClientID == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // GET: Clients/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Microsoft.AspNetCore.Mvc.Bind("ClientID,ClientUserName,FirstName,LastName,PhoneNumber,Email,Password,City,Address")] Client client)
        {
            if (ModelState.IsValid)
            {
                _context.Add(client);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }
        [Authorize(Roles = "Admin")]
        // GET: Clients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Client.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            return View(client);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Microsoft.AspNetCore.Mvc.Bind("ClientID,ClientUserName,FirstName,LastName,PhoneNumber,Email,Password,City,Address")] Client client)
        {
            if (id != client.ClientID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(client);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(client.ClientID))
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
            return View(client);
        }
        [Authorize(Roles = "Admin")]
        // GET: Clients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Client
                .FirstOrDefaultAsync(m => m.ClientID == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // POST: Clients/Delete/5
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.ActionName("Delete")]
        [Microsoft.AspNetCore.Mvc.ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var client = await _context.Client.FindAsync(id);
            _context.Client.Remove(client);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientExists(int id)
        {
            return _context.Client.Any(e => e.ClientID == id);
        }


        public IActionResult Login()
        {
            return View();
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Client.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                SignInAsync(user);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        
        private async Task SignInAsync(Client user)
        {
            
                var claims = new List<Claim>
        {
            new Claim ("UserName", user.ClientUserName),
            new Claim ("UserEmail", user.Email),
            new Claim ("FullName", user.FirstName+" "+user.LastName),
            new Claim (ClaimTypes.Role, user.Type.ToString()),
            new Claim ("Type", user.Type.ToString())

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
        
        [Microsoft.AspNetCore.Mvc.HttpPost]
         public async Task<IActionResult> Register( string FirstName, string LastName, string PhoneNumber, string Email, string
            Password, string City, string Address)
        {

            Client NewClient = new Client()
            {
                ClientUserName = FirstName,
                FirstName = FirstName,
                LastName = LastName,
                PhoneNumber = PhoneNumber,
                Email = Email,
                Password = Password,
                City = City,
                Address = Address,
                Type = clientType.Client
            };
            _context.Add(NewClient);
            await _context.SaveChangesAsync();
            SignInAsync(NewClient);
            return RedirectToAction("Index", "Home");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Search(string ClientUserName)

        {
            List<Client> clients = new List<Client>();
            foreach (Client c in _context.Client)
                clients.Add(c);
            
            if (ClientUserName != null)
            {
                foreach (Client c in _context.Client)
                {
                    if (!(c.ClientUserName.ToLower().Contains(ClientUserName.ToLower())))
                    
                        clients.Remove(c);
                }
            }
            return View("Index", clients);
        }
        
    }
}
