

using Core.Domain.Entities.Categories;
using Core.Domain.Entities.Categories.ValueObjects;
using Core.Domain.Entities.Comments;
using Core.Domain.Entities.Posts.ValueObjects;
using Core.Domain.Entities.PostsStatus;
using Core.Domain.Entities.Users;
using Core.Domain.Entities.Users.ValueObjects;
using Core.Domain.Posts.ValueObjects;
using Core.Domain.PostsStatus;


namespace Core.Domain.Entities.Posts
{
   public sealed class Post
    {
        public PostId PostId { get; set; }

        public Title Title { get; set; } 
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public UserId UserId { get; set; }
        public CategoryId CategoryId { get; set; } 
        public int StatusId { get; set; } 
        public DateTime? ModifiedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? DeletedAt { get; set; }

        // Navigation Properties
        public User User { get; set; }
        public Category Category { get; set; }
        public PostStatus Status { get; set; }
        public List<Comment> Comments { get; set; } = new();


    }
}
