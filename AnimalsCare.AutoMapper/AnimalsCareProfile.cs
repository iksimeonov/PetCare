using AnimalsCare.Models;
using AnimalsCare.ViewModels;
using AutoMapper;

namespace AnimalsCare.AutoMapper
{
    public  class AnimalsCareProfile : Profile
    {
        public AnimalsCareProfile()
        {
            this.CreateMap<BlogAddInputViewModel, Blog>();
            this.CreateMap<Blog, BlogsAllViewModel>();
            this.CreateMap<Blog, BlogDetailsViewModel>();
            this.CreateMap<Blog, BlogEditViewModel>();
            this.CreateMap<Blog, LastBlogsViewModels>();

            this.CreateMap<ContactAddViewModel, Contact>();

            this.CreateMap<ConsultationAddViewModel, Consultation>();
        }
    }
}
