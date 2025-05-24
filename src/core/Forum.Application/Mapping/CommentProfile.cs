using AutoMapper;

using Core.Domain.Entitites.Comments;
using Forum.Application.Features.Comments;


namespace Forum.Application.Mapping;

public class CommentProfile : Profile
{
    public CommentProfile()
    {
        CreateMap<Comment, CommentResponse>()
            .ForMember(dest => dest.CommentId, opt => opt.MapFrom(src => src.CommentId.Value))
            .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content.Value))
            .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt));
    }
    
}