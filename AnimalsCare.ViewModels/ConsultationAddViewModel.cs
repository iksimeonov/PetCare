

using System;
using System.ComponentModel.DataAnnotations;

namespace AnimalsCare.ViewModels
{
  public  class ConsultationAddViewModel
    {
        [Required]
        public string Service { get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"\d{10}")]
        public string Phone { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(5)]
        public string Message { get; set; }
    }
}
