
using Core.Domain.Common.Results;
using MediatR;

namespace Forum.Application.Features.Posts.Commands.CreatePost
{
    public record CreatePostCommand(
        Guid postId,
        string title,
        Guid userId,
        Guid categoryId,
        int statusId,
        DateTime? modifiedAt,
        bool isDeleted,
        DateTime? deletedAt)
        : IRequest<ResultT<PostResponse>>;

}