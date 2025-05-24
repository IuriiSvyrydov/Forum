using AutoMapper;
using Core.Domain.Common.Results;
using Core.Domain.Entities.Users;
using Core.Domain.Entities.Users.ValueObjects;
using Core.Domain.Entitites.Users;
using Core.Domain.Entitites.Users.ValueObjects;
using MediatR;

namespace Forum.Application.Features.Users.Commands.CreateUser
{
    public sealed class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, ResultT<UserResponse>>
    {
        private readonly IUserWriteRepository _userWriteRepository;
        private readonly IMapper _mapper;

        public CreateUserCommandHandler(IUserWriteRepository userWriteRepository, IMapper mapper)
        {
            _userWriteRepository = userWriteRepository;
            _mapper = mapper;
        }

        public async Task<ResultT<UserResponse>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var createUser = User.Create(
            UserId.NewId(),
             request.UserIdentityId,
             new Username(request.Username),
             new ProfilePictureUrl(request.ProfilePictureUrl),
             request.RegisteredAt,
             request.CanPost,
             new Email(request.Email)   
            );
            await _userWriteRepository.AddAsync(createUser);
            return ResultT<UserResponse>.Success(_mapper.Map<UserResponse>(createUser));
        }
    }
}