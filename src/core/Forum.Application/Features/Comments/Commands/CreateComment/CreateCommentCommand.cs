using Core.Domain.Common.Results;
using MediatR;

namespace Forum.Application.Features.Comments.Commands.CreateComment;

public sealed record CreateCommentCommand(string Content, DateTime CreatedAt,Guid UserId,Guid PostId) : IRequest<ResultT<Unit>>;
