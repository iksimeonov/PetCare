using Microsoft.AspNetCore.Identity;

namespace AnimalsCare.Models
{
   public class ApplicationRole : IdentityRole
    {
        public ApplicationRole()
            : this(null)
        {
        }
        public ApplicationRole(string roleName) : base(roleName)
        {

        }
    }
}
