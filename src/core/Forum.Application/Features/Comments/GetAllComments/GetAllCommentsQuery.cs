using MediatR;
using Core.Domain.Common.Results;

namespace Forum.Application.Features.Comments.GetAllComments;

public record GetAllCommentsQuery : IRequest<ResultT<List<CommentResponse>>>;
