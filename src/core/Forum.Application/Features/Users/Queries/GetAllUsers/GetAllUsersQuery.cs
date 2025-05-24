using Core.Domain.Common.Results;
using Forum.Application.Features.Users.Commands;
using MediatR;

namespace Forum.Application.Features.Users.Queries.GetAllUsers;

public record GetAllUsersQuery() : IRequest<ResultT<List<UserResponse>>>;
