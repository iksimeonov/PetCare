using System.ComponentModel.DataAnnotations;

namespace AnimalsCare.ViewModels
{
    public   class BlogEditViewModel
    {
        public string Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Title { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [MinLength(20)]
        public string Description { get; set; }
    }
}
