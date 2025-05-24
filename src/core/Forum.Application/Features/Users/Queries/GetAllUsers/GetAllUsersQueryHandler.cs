using AutoMapper;
using Core.Domain.Common.Results;
using Core.Domain.Entitites.Users;
using Forum.Application.Features.Users.Commands;
using Forum.Application.Mapping;
using MediatR;

namespace Forum.Application.Features.Users.Queries.GetAllUsers;

public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery,ResultT< List<UserResponse>>>
{
    private readonly IUserReadRepository _userReadRepository;
    private readonly IMapper _mapper;

    public GetAllUsersQueryHandler(IUserReadRepository userReadRepository, IMapper mapper)
    {
        _userReadRepository = userReadRepository;
        _mapper = mapper;
    }

    public async Task<ResultT<List<UserResponse>>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        var users = await _userReadRepository.GetAllAsync();
        return ResultT<List<UserResponse>>.Success(_mapper.Map<List<UserResponse>>(users));
    }
}