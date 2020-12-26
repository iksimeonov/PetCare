using System;
using System.ComponentModel.DataAnnotations;

namespace AnimalsCare.Models
{
    public  class Blog
    {
        public string Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime  CreatedOn{ get; set; }

        [Required]
        public string CreatorId { get; set; }

        public virtual ApplicationUser Creator { get; set; }
    }
}
