

using Core.Domain.Entities.Users.ValueObjects;
using Core.Domain.Entitites.Users.ValueObjects;

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

    //constructors
    public User(UserId userId, string userIdentityId, Username username, ProfilePictureUrl? profilePictureUrl, DateTime registeredAt, bool canPost, Email email)
    {
        UserId = userId;
        UserIdentityId = userIdentityId;
        Username = username;
        ProfilePictureUrl = profilePictureUrl;
        RegisteredAt = registeredAt;
        CanPost = canPost;
        Email = email;
    }
    // static factories
    public static User Create(UserId userId, string userIdentityId, Username username, ProfilePictureUrl? profilePictureUrl, DateTime registeredAt, bool canPost, Email email)
    {
        return new User(userId, userIdentityId, username, profilePictureUrl, registeredAt, canPost, email);
    }

}
