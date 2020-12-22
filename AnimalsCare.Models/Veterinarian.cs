using AnimalsCare.Models.Enums;
using System;

namespace AnimalsCare.Models
{
    public  class Veterinarian
    {
        public Veterinarian()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public Specialty  Specialty{ get; set; }

        public string ImageUrl { get; set; }

        public string Info { get; set; }
    }
}
