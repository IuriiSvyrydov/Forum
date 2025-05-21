
using Core.Domain.Entities.Comments;
using Core.Domain.Entities.Comments.ValueObjects;
using Core.Domain.Entities.Posts.ValueObjects;
using Core.Domain.Entities.SubComments.ValueObjects;
using Core.Domain.Entities.Users;
using Core.Domain.Entities.Users.ValueObjects;

namespace Core.Domain.Entities.SubComments
{
    public sealed class SubComment
    {
        public SubCommentId SubCommentId { get; set; }
        public Content Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public CommentId CommentId { get; set; }
        public UserId UserId { get; set; }

        public Comment Comment { get; set; }
        public User User { get; set; }
    }
}