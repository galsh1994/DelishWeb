using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.AspNetCore.Mvc;
using delishapplication.Models;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace delishapplication.Controllers
{
    public class HomeController : Controller { 

    private readonly delishapplicationContext _context;

        public HomeController(delishapplicationContext context)
        {
            _context = context;
        }
        [Authorize]
        public IActionResult Index()
        {
            
            Dish[] bestDishes = _context.Dish.OrderByDescending(p => p.Popularity).ToArray();
            Dish bestDish = bestDishes.First();
            Chef[] bestChefs = _context.Chef.OrderByDescending(p => p.Popularity).ToArray();
            Chef bestChef = bestChefs.First();

            ViewBag.bestDishesGrid = bestDishes;
            ViewBag.bestDishesGrid1 = bestDishes[1];
            ViewBag.bestDishesGrid2= bestDishes[2];
            ViewBag.bestDishesGrid3 = bestDishes[3];
            ViewBag.bestDishesGrid4 = bestDishes[4];



            ViewBag.bestDishName = bestDish.DishName;
            ViewBag.bestDishDesc = bestDish.Description;
            ViewBag.bestDishID = bestDish.DishID;
            ViewBag.bestDishPrice = bestDish.Price;
            ViewBag.bestDishPhoto = bestDish.PhotoLink;
            ViewBag.bestChefName = bestChef.ChefUserName;
            
            var s = "https://localhost:44382/chefs/Details/" + bestChef.ChefID.ToString();

            ViewBag.bestChefAddress = s;
            ViewBag.bestChefCuisine = bestChef.Cuisine;
            ViewBag.bestChefPhoto = bestChef.PhotoLink;
            return View();
        }
       
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {
            return View();
        }
        public IActionResult FirstPage()
        {
            return View();
        }
        [Authorize]
        public IActionResult DishGraph()
        {
            Dish[] bestDishes = _context.Dish.OrderByDescending(p => p.Popularity).ToArray();
            List<string> theDishName = new List<string>();
            List<int> theDishPop = new List<int>();

            for (int i = 0; i < bestDishes.Length; i++)
            {
                theDishName.Add(bestDishes[i].DishName);
                theDishPop.Add(bestDishes[i].Popularity);
            }

            if (theDishName.Count >= 1)
            {
                ViewBag.graphDishName1 = theDishName.ElementAt(0);
                ViewBag.graphDishPOP1 = theDishPop.ElementAt(0);
            }
            if (theDishName.Count >= 2)
            {
                ViewBag.graphDishName2 = theDishName.ElementAt(1);
                ViewBag.graphDishPOP2 = theDishPop.ElementAt(1);
            }
            if (theDishName.Count >= 3)
            {
                ViewBag.graphDishName3 = theDishName.ElementAt(2);
                ViewBag.graphDishPOP3 = theDishPop.ElementAt(2);
            }

            return View();
        }

        public IActionResult ChefGraph()
        {
            Chef[] bestChefs = _context.Chef.OrderByDescending(p => p.Popularity).ToArray();

            List<string> thechefs = new List<string>();
            List<int> thepop = new List<int>();
            

            for (int i = 0; i < bestChefs.Length; i++)
            {
                thechefs.Add(bestChefs[i].ChefUserName);
                thepop.Add(bestChefs[i].Popularity);
            }

            if (thechefs.Count >= 1)
            {
                ViewBag.graphChefList1 = thechefs.ElementAt(0);
                ViewBag.graphPopList1 = thepop.ElementAt(0);
            }
            if (thechefs.Count >= 2)
            {
                ViewBag.graphChefList2 = thechefs.ElementAt(1);
                ViewBag.graphPopList2 = thepop.ElementAt(1);
            }
            if (thechefs.Count >= 3)
            {
                ViewBag.graphChefList3 = thechefs.ElementAt(2);
                ViewBag.graphPopList3 = thepop.ElementAt(2);
            }
            return View();
        }

        [Authorize]
        public IActionResult AboutUs()
        {
            Branch[] Branches = _context.Branch.ToArray();

            ViewBag.firstbranchlat = Branches[0].Alt;
            ViewBag.firstbranchlong = Branches[0].Lng;
            ViewBag.secondbranchlat = Branches[1].Alt;
            ViewBag.secondbranchlong = Branches[1].Lng;
            ViewBag.thirdbranchlat = Branches[2].Alt;
            ViewBag.thirdbranchlong = Branches[2].Lng;

            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)] 
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        

    }
}
