using Core.Domain.Common.Errors;
using Core.Domain.Entities.Comments.ValueObjects;
using Core.Domain.Entities.Posts;
using Core.Domain.Entities.SubComments;
using Core.Domain.Entities.Users;
using Core.Domain.Entities.Users.ValueObjects;
using Core.Domain.Entitites.SubComments;
using Core.Domain.Common.Results;
using Core.Domain.Entitites.Posts.ValueObjects;
using Core.Domain.Entitites.Users.ValueObjects;

namespace Core.Domain.Entitites.Comments;

public sealed class Comment
{
    private Comment() { }

    public CommentId CommentId { get; private set; }
    public CommentContent Content { get; private set; }
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public UserId UserId { get; private set; }
    public PostId PostId { get; private set; }

    // Navigation Properties
    public User User { get; set; }
    public Post Post { get; set; }
    public List<SubComment> SubComments { get; private set; } = new();

    public static ResultT<Comment> Create(
        CommentId commentId,
        CommentContent content,
        UserId userId,
        PostId postId)
    {
        if (commentId is null)
            return ResultT<Comment>.Failed(Error.BadRequest("CommentId cannot be null","CommentId cannot be null"));

        if (content is null || content.Value.Length < 1 || content.Value.Length > 1000)
            return ResultT<Comment>.Failed(
                Error.BadRequest("Content must be between 1 and 1000 characters","Content must be between 1 and 1000 characters"));

        if (userId is null)
            return ResultT<Comment>.Failed(Error.BadRequest("UserId cannot be null","UserId cannot be null"));

        if (postId is null)
            return ResultT<Comment>.Failed(Error.BadRequest("PostId cannot be null","PostId cannot be null"));

        var comment = new Comment
        {
            CommentId = commentId,
            Content = content,
            UserId = userId,
            PostId = postId,
            CreatedAt = DateTime.UtcNow
        };

        return ResultT<Comment>.Success(comment);
    }

  


}
