using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AnimalsCare.Models
{
    public  class Blog
    {
        public Blog()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Comments = new HashSet<Comment>();
        }
        public string Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Title { get; set; }

        [Required]
        [MinLength(20)]
        public string Description { get; set; }

        public DateTime  CreatedOn{ get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
