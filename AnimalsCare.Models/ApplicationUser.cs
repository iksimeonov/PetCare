
using Microsoft.AspNetCore.Identity;
using System;

namespace AnimalsCare.Models
{
  public  class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
