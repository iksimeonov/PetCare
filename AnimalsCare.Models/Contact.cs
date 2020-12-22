using System;
using System.ComponentModel.DataAnnotations;

namespace AnimalsCare.Models
{
    public   class Contact
    {
        public Contact()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(2)]
        public string Subject { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
