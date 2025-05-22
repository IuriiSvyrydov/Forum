using Core.Domain.Entities.Comments.ValueObjects;
using Core.Domain.Entities.Posts;
using Core.Domain.Entities.SubComments;
using Core.Domain.Entities.Users;
using Core.Domain.Entities.Users.ValueObjects;
using Core.Domain.Posts.ValueObjects;

namespace Core.Domain.Entitites.Comments;

   public sealed class Comment
    {
    public CommentId CommentId { get; set; }
    public CommentContent Content { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public UserId   UserId { get; set; }
    public PostId PostId { get; set; }

    //Navigation Properties
    public User User { get; set; }
    public Post Post { get; set; }
    public List<SubComment> SubComments { get; set; } = new();
}

