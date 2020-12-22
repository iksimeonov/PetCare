using AnimalsCare.Models.Enums;

namespace AnimalsCare.ViewModels
{
  public  class VeterinarianAllViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Specialty Specialty { get; set; }

        public string ImageUrl { get; set; }

        public string Info { get; set; }
    }
}
