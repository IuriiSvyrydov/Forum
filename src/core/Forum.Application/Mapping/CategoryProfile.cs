using AutoMapper;
using Core.Domain.Entities.Categories;
using Forum.Application.Features.Categories.Commands.CreateCategory;
using Forum.Application.Features.Categories.Commands.UpdateCategory;
using Forum.Application.Features.Categories.Responses;

namespace Forum.Application.Mapping
{
    class CategoryProfile: Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryResponse>()
                .ForMember(dest => dest.CategoryId, opt
                    => opt.MapFrom(src => src.CategoryId.Value))
                .ForMember(dest=>dest.PostCount,opt
                    =>opt.MapFrom(src=>src.PostCount.Value))
                .ForMember(dest=>dest.Name,opt
                    =>opt.MapFrom(x=>x.Name.Value))
                .ForMember(dest=>dest.Description,
                    opt=>opt.MapFrom(x=>x.Description.Value))
                .ForMember(dest=>dest.ImageUrl,opt
                    =>opt.MapFrom(x=>x.ImageUrl.Value));
            CreateMap<CreateCategoryCommand, Category>().ReverseMap();
          
        
            
            
CreateMap<Category, UpdateCategoryResponse>()
    .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId.Value))
    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name.Value))
    .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description.Value))
    .ForMember(dest => dest.PostCount, opt => opt.MapFrom(src => src.PostCount.Value))
    .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl.Value));
        }
    }
}