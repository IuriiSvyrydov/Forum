

using Core.Domain.Entities.Users.ValueObjects;

namespace Core.Domain.Entities.Users;

public class User
{
    public UserId UserId { get; set; }
    public string UserIdentityId { get; set; } 
    public Username Username { get; set; } 
    public ProfilePictureUrl? ProfilePictureUrl { get; set; } 
    public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
    public bool CanPost { get; set; } = true; 
    public Email Email { get; set; }

}
