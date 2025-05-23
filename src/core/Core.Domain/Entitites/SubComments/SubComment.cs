using Core.Domain.Entities.Comments.ValueObjects;
using Core.Domain.Entities.SubComments.ValueObjects;
using Core.Domain.Entities.Users;
using Core.Domain.Entities.Users.ValueObjects;
using Core.Domain.Entitites.Comments;
using Core.Domain.Entitites.SubComments.ValueObjects;
using Core.Domain.Entitites.Users.ValueObjects;

namespace Core.Domain.Entitites.SubComments
{
    public sealed class SubComment
    {
        public SubCommentId SubCommentId { get; set; }
        public SubCommentContent SubCommentContent { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public CommentId CommentId { get; set; }
        public UserId UserId { get; set; }
        public Comment Comment { get; set; }
        public User User { get; set; }
    }
}