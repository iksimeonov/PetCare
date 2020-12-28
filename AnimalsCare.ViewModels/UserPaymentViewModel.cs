using System;
using System.ComponentModel.DataAnnotations;

namespace AnimalsCare.ViewModels
{
  public  class UserPaymentViewModel
    {
        public int Package { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name ="Starting Date")]
        public DateTime Date { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]{1}[a-z]* [A-Z]{1}[a-z]*$")]
        [Display(Name = "Cardholder Names")]
        public string CardholderNames { get; set; }

        [Required]
        [RegularExpression(@"^\d{16}$")]
        [Display(Name = "Card Number")]
        public string CardNumber { get; set; }

        [Required]
        [RegularExpression(@"^\d{2}\/\d{2}$")]
        [Display(Name = "Expiration Date")]
        public string ExpirationDate { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}$")]
        public string Cvv { get; set; }
    }
}
