using System;
using System.ComponentModel.DataAnnotations;

namespace AnimalsCare.Models
{
    public  class Comment
    {
        public Comment()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        [Required]
        [MinLength(6)]
        public string Message { get; set; }

    
        public string BlogId { get; set; }
        public virtual Blog Blog { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}
