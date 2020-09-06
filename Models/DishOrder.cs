using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace delishapplication.Models
{
    public class DishOrder
    {

        public Dish Dish { get; set; }
        public int DishID { get; set; }
        public Order Order { get; set; }
        public int OrderID { get; set; }
    }
}
