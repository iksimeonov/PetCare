using System;

namespace AnimalsCare.ViewModels
{
    public   class BlogAddInputViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedOn{ get; set; }
    
        public string ImageUrl { get; set; }

    }
}
