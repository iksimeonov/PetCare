

using System.ComponentModel.DataAnnotations;

namespace AnimalsCare.ViewModels
{
    public class ContactAddViewModel
    {

        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(2)]
        public string Subject { get; set; }

        [Required]
        [MinLength(5)]
        public string Message { get; set; }
    }
}
