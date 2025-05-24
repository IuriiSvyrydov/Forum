

using Core.Domain.Entities.Categories;
using Core.Domain.Entities.Categories.ValueObjects;
using Core.Domain.Entities.Comments;
using Core.Domain.Entities.Posts.ValueObjects;
using Core.Domain.Entities.PostsStatus;
using Core.Domain.Entities.Users;
using Core.Domain.Entities.Users.ValueObjects;
using Core.Domain.Entitites.Comments;
using Core.Domain.Entitites.Posts.ValueObjects;
using Core.Domain.Entitites.Users.ValueObjects;
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
        //constructors
        public Post(PostId postId, Title title, UserId userId, CategoryId categoryId, int statusId, DateTime? modifiedAt, bool isDeleted, DateTime? deletedAt)
        {
            PostId = postId;
            Title = title;
            UserId = userId;
            CategoryId = categoryId;
            StatusId = statusId;
            ModifiedAt = modifiedAt;
            IsDeleted = isDeleted;
            DeletedAt = deletedAt;
        }
        private Post() { }
        //static factories
        public static Post Create(PostId postId, Title title, UserId userId, CategoryId categoryId, int statusId, DateTime? modifiedAt, bool isDeleted, DateTime? deletedAt)
        {
            return new Post(postId, title, userId, categoryId, statusId, modifiedAt, isDeleted, deletedAt);
        }








    }
}
