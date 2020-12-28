using System;
using System.ComponentModel.DataAnnotations;

namespace AnimalsCare.ViewModels
{
    public   class BlogAddInputViewModel
    {
        [Required]
        [MinLength(2)]
        public string Title { get; set; }

        [Required]
        [MinLength(20)]
        public string Description { get; set; }

        [Display(Name = "Date")]
        public DateTime CreatedOn{ get; set; }
    
        [Required]
        public string ImageUrl { get; set; }

    }
}
