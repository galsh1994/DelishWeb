using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace delishapplication.Models

{
   
    public enum ChefType
    {
        Admin, Chef
    }
    public class Chef
    {
       
        public int ChefID { set; get; }

        [Display(Name = "Resturant Name:")]
        [Required]
        [RegularExpression(@"^[A-Za-z0-9\s]*$")]
        public String ChefUserName { set; get; }

        [Display(Name = "First Name:")]
        [Required]
        [RegularExpression(@"^[A-Za-z0-9\s]*$")]
        public String FirstName { set; get; }

        [Display(Name = "Last Name:")]
        [Required]
        [RegularExpression(@"^[A-Za-z0-9\s]*$")]
        public String LastName { set; get; }

        [Display(Name = "Phone Number:")]
        [Required]
        [RegularExpression(@"^[0-9\s]*$")]
        public String PhoneNumber { set; get; }

        [Display(Name = "E-mail:")]
        [Required]
        public String Email { set; get; }

        [Display(Name = "Password:")]
        [Required]
        [RegularExpression(@"^[A-Za-z0-9\s]*$")]
        public String Password { set; get; }

        [Display(Name = "Years of Experience:")]
        [Required]
        [RegularExpression(@"^[0-9\s]*$")]
        public int Experience { set; get; }

        [Display(Name = "City:")]
        [Required]
        [RegularExpression(@"^[A-Za-z\s]*$")]
        public String City { set; get; }

        [Display(Name = "Kosher")]
        public Boolean Kosher { set; get; }

        [Display(Name = "Cuisine:")]
        [Required]
        [RegularExpression(@"^[A-Za-z\s]*$")]
        public String Cuisine { set; get; }

        [Display(Name = "My Dishes:")]
        //   [Required]
        [RegularExpression(@"^[A-Za-z0-9\s]*$")]
        public virtual ICollection<Dish> MyDishes { get; set; }

        public ChefType Type { get; set; }

        public int Popularity { set; get; }

        public string PhotoLink { set; get; }
    }
}
