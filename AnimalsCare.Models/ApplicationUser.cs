
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace AnimalsCare.Models
{
  public  class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Blogs = new HashSet<Blog>();
            this.Payments = new HashSet<Payment>();
        }

       public virtual ICollection<Blog> Blogs{ get; set; }
        public virtual ICollection<Comment> Comments{ get; set; }
        public virtual ICollection<Payment> Payments{ get; set; }
    }
}
