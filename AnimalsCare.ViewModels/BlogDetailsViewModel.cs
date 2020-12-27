

using System;
using System.Collections.Generic;

namespace AnimalsCare.ViewModels
{
   public class BlogDetailsViewModel
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string CreatorUsername { get; set; }

        public DateTime  CreatedOn { get; set; }

        public string CreatedOnToString => this.CreatedOn.ToString("dd/MM/yyyy");

        public ICollection<CommentPostViewModel> Comments { get; set; }

        public int CommentsCount => this.Comments.Count;
    }
}
