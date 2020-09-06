 
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace delishapplication.Models

{
    public class Dish
    {
        public int DishID { set; get; }

        [Display(Name = "Dish Name:")]
        [Required]
        [RegularExpression(@"^[A-Za-z0-9\s]*$")]
        public String DishName { set; get; }


        public int Price { set; get; }

        [Display(Name = "Spicy")]
        public Boolean Spicy { set; get; }
        [Display(Name = "Vegan")]
        public Boolean Vegan { set; get; }
        public Chef Chef { set; get; }
        [Display(Name = "Description:")]
        public String Description { set; get; }
        public virtual ICollection<DishOrder> DishOrder { set; get; }
         public int Popularity { set; get; }
        public string PhotoLink { set; get; }


    }
}


