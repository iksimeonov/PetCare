using System;
using System.ComponentModel.DataAnnotations;

namespace AnimalsCare.Models
{
    public  class Consultation
    {
        public Consultation()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        [Required]
        public string Service { get; set; }

        public DateTime Date{ get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"\d{10}")]
        public string Phone { get; set; }

        [Required]
       [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(5)]
        public string Message { get; set; }
    }
}
