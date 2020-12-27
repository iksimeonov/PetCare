using System;

namespace AnimalsCare.ViewModels
{
  public  class BlogsAllViewModel
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedOnToString => this.CreatedOn.ToString("dd/MM/yyyy");

        public string CreatorUsername { get; set; }
    }
}
