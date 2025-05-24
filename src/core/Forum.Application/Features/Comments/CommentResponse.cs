namespace Forum.Application.Features.Comments;

public class CommentResponse
{
    public Guid CommentId { get; set; }
 
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }

}