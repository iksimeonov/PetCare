using AnimalsCare.Data;
using AnimalsCare.Models;
using AnimalsCare.Models.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalsCare.Services
{
    public class SeedingVeterinarians : ISeedingVeterinarians
    {
        private readonly ApplicationDbContext db;

        public SeedingVeterinarians(ApplicationDbContext db)
        {
            this.db = db;
        }
        public async Task AddVegetariansAsync()
        {

            var veterinarians = new List<Veterinarian>
            {

                { new Veterinarian
                {
                     FirstName = "Philipa",
                      LastName = "Fawson",
                       ImageUrl = "https://www.indiaeducation.net/imagesvr_ce/8982/iStock_000009819502Small.jpg",
                       Specialty = Specialty.Dogs,
                        Info = "In 2005, she graduated from the University of Queensland and was then posted to Merredin as a Veterinary Officer in 2007. She served there until being transferred to Moora in 2010. In the middle of that year, Back resigned and went into racehorse practice in Caulfield, Victoria.",
                }},

                { new Veterinarian
                {
                     FirstName = "Ryan",
                      LastName = "Conner",
                       ImageUrl = "https://previews.123rf.com/images/vadimgozhda/vadimgozhda1412/vadimgozhda141201444/34916637-young-male-vet-doctor-with-cat-veterinary-clinic-.jpg",
                       Specialty = Specialty.Cats,
                        Info = "Conner was born and grew up in the suburbs of Merewether Heights, Newcastle, New South Wales, where his father was a local vet. He attended Merewether Heights Public School and Merewether High School. He graduated from The University of Sydney with First Class Honours in Veterinary Science in 2009.",
                }},


                { new Veterinarian
                {
                     FirstName = "Amanda",
                      LastName = "Hawk",
                       ImageUrl = "https://bloximages.newyork1.vip.townnews.com/coastalview.com/content/tncms/assets/v3/editorial/1/c8/1c8ef7ac-fc0f-11e9-9360-0bc2455f3dee/5dbb2ca08dc11.image.jpg?crop=1178%2C1242%2C0%2C112",
                       Specialty = Specialty.Reptiles,
                        Info = "Born into a bourgeois environment of the city of Versailles,she has been passionate about animals since childhood. In 2006, she began studying to be a veterinarian at the École nationale vétérinaire d'Alfort.[4] After graduating, she worked for a few months in rural areas of France, before flying to the Central African Republic",
                }},

                { new Veterinarian
                {
                     FirstName = "Scott",
                      LastName = "Johnson",
                       ImageUrl = "https://vcahospitals.com/-/media/vca/images/lifelearn-images-foldered/905/new_bird_visit-1.jpg?la=en&hash=2BE1E29D6F63966897BE85AC1A9CE979",
                       Specialty = Specialty.Birds,
                        Info = "He was born in London and studied veterinary medicine at the University of Edinburgh. In 1999 he entered King's College, Cambridge, where he commenced work on a doctorate, which he gained in 2003. Before finishing his doctorate, he developed and published methods to detect antibodies with Arthur Mourant and Robert Russell Race in 2002",
                     }
                },

            };
            await this.db.Veterinarians.AddRangeAsync(veterinarians);
            await this.db.SaveChangesAsync();

        }

        public bool Any()
        {
            return this.db.Veterinarians.Any();
        }
    }
}
