using AutoMapper;
using Core.Domain.Entities.Users;
using Core.Domain.Entities.Users.ValueObjects;
using Core.Domain.Entitites.Users.ValueObjects;
using Forum.Application.Features.Users.Commands;
using Forum.Application.Features.Users.Commands.CreateUser;

namespace Forum.Application.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            // Configure value object to primitive type conversions
            CreateMap<UserId, Guid>().ConvertUsing(src => src.Value);
            CreateMap<Username, string>().ConvertUsing(src => src.Value);
            CreateMap<ProfilePictureUrl, string>().ConvertUsing(src => src.Value);
            CreateMap<Email, string>().ConvertUsing(src => src.Value);

            // Configure primitive type to value object conversions
            CreateMap<Guid, UserId>().ConvertUsing(src => new UserId(src));
            CreateMap<string, Username>().ConvertUsing(src => new Username(src));
            CreateMap<string, ProfilePictureUrl>().ConvertUsing(src => string.IsNullOrEmpty(src) ? null : new ProfilePictureUrl(src));
            CreateMap<string, Email>().ConvertUsing(src => new Email(src));

            // Configure User to UserResponse mapping with ReverseMap
            CreateMap<User, UserResponse>()
                .ReverseMap();

            // Configure CreateUserCommand to User mapping
            CreateMap<CreateUserCommand, User>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(_ => UserId.NewId()));
        }
    }
}