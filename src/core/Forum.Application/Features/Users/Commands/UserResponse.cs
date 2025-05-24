using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Application.Features.Users.Commands;

public record UserResponse(
    Guid UserId,
    string UserIdentityId,
    string Username,
    string ProfilePictureUrl,
    DateTime RegisteredAt,
    bool CanPost,
    string Email);
    
    
    
