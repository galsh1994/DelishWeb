

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace delishapplication.Models
{
    public class Order
    {

        public int OrderID { set; get; }

        public int OrderNumber { set; get; }

        [Display(Name = "Order date:")]
         public DateTime OrderDate { set; get; }

         [Display(Name = "Arrival Date:")]
        //       [Required]
        public DateTime ArrivalDate { set; get; }

        [Display(Name = "Ordered By:")]
        //       [Required]
         public String ClientUserName { set; get; }

        //       [Required]
         [Display(Name = "Made By:")]
        public Chef Chef { set; get; }

        //        [DataType(DataType.Currency)]
         [Display(Name = "Total Price:")]

        public int TotalPrice { set; get; }
        [Display(Name = "My cart:")]
        public virtual ICollection<DishOrder> DishOrder { set; get; }
    }
}