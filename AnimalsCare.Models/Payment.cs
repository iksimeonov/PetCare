using System;

namespace AnimalsCare.Models
{
    public   class Payment
    {
        public Payment()
        {
            this.Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }

        public int Price { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime Date { get; set; }
    }
}
