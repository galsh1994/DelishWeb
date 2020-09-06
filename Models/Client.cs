    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;


namespace delishapplication.Models
{
    public enum clientType
    {
        Client=2
    }
    public class Client
    {
        public int ClientID { set; get; }

        [Display(Name = "User Name:")]
        [Required]
        [RegularExpression(@"^[A-Za-z0-9\s]*$")]
        public String ClientUserName { set; get; }

        [Display(Name = "First Name:")]
        [Required]
        [RegularExpression(@"^[A-Za-z0-9\s]*$")]
        public String FirstName { set; get; }

        [Display(Name = "Last Name:")]
        [Required]
        [RegularExpression(@"^[A-Za-z0-9\s]*$")]
        public String LastName { set; get; }

        [Display(Name = "Phone number:")]
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

        [Display(Name = "City:")]
        [Required]
        [RegularExpression(@"^[A-Za-z0-9\s]*$")]
        public String City { set; get; }

        [Display(Name = "Address:")]
        [Required]
        [RegularExpression(@"^[A-Za-z0-9\s]*$")]
        public String Address { set; get; }
        public virtual ICollection<Order> MyOrders { get; set; }
        public clientType Type { get; set; }

    }
}
