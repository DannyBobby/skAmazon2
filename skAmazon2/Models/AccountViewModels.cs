using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace skAmazon2.Models
{
    // grabs the persons username from whatever external source they used to login
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }
    }


    // allows the user to Change their password
    public class ManageUserViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    // requests information specific for authentication
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    // binds together a few different models to create a new ApplicationUser with a "default" address and payment method
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [DisplayName("First Name")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName("Last Name")]
        [StringLength(160)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(70)]
        public string AddrLine1 { get; set; }

        [StringLength(70)]
        public string AddrLine2 { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required")]
        [StringLength(40)]
        public string State { get; set; }

        [Required(ErrorMessage = "ZIP is required")]
        [DisplayName("ZIP")]
        [StringLength(10)]
        public string ZIP { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [DisplayName("Country")]
        [StringLength(40)]
        public string Country { get; set; }

        [ScaffoldColumn(false)]
        public System.DateTime AddressDateCreated { get; set; }

        [Required(ErrorMessage = "Payment Method Description is Required")]
        [DisplayName("Payment Method Description")]
        [StringLength(40)]
        public string PaymentDescription { get; set; }

        [Required(ErrorMessage = "Card Number is Required")]
        [StringLength(20)]
        public Nullable<int> CardNumber { get; set; }

        [Required(ErrorMessage = "Expiration Date is Required")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> ExpirationDate { get; set; }

        [Required(ErrorMessage = "Security Code is Required")]
        [StringLength(10)]
        public Nullable<int> SecurityCode { get; set; }

        [ScaffoldColumn(false)]
        public System.DateTime PaymentDateCreated { get; set; }

        [Required(ErrorMessage = "Payment Type (VISA, MasterCard, etc.) is required")]
        public string PaymentType { get; set; }


    }
}
