using System;

namespace AnimalsCare.ViewModels
{
    public  class CommentPostViewModel
    {
        public string Message { get; set; }

        public DateTime CreatedOn{ get; set; }

        public string CreatedOnToString => this.CreatedOn.ToString("dd/MM/yyyy");

        public string UserUsername { get; set; }
    }
}
