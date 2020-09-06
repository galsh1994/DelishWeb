using delishapplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace delishapplication.Data
{
    public class DbInit
    {
        public static void init(delishapplicationContext _context)
        {
            if (!_context.Chef.Any())
            {
                {

                    Chef c = new Chef()
                    {
                        ChefUserName = "MyKitchen",
                        Cuisine = "Israeli",
                        City = "Tel-Aviv",
                        Email = "Moshel@gmail.com",
                        Experience = 5,
                        FirstName = "Moshe",
                        LastName = "Levi",
                        Kosher = false,
                        PhoneNumber = "0523454334",
                        Password = "2323",
                        MyDishes = null
                    };

                    _context.Add(c);


                    }
                _context.SaveChanges(); 
            }
        }
    }
}
