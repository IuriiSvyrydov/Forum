
using Core.Domain.Common.Results;
using Forum.Application.Features.Users.Commands;
using MediatR;


namespace Forum.Application.Features.Users.Commands.CreateUser
{
    public record CreateUserCommand(
        string UserIdentityId,
        string Username,
        string ProfilePictureUrl,
        DateTime RegisteredAt,
        bool CanPost,
        string Email) : IRequest<ResultT<UserResponse>>;

}