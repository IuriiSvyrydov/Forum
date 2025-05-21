namespace Core.Domain.Entities.Comments.ValueObjects;

public record CommentContent
{
    public string Value { get; init; }

    private CommentContent() { }
    
    public CommentContent(string value)
    {
        Value = value ?? throw new ArgumentNullException(nameof(value));
        if (value.Length > 500)
            throw new ArgumentException("CommentContent cannot be longer than 500 characters");
    }
}
