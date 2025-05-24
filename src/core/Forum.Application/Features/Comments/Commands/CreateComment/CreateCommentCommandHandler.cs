using AutoMapper;
using Core.Domain.Common.Results;
using Core.Domain.Entities.Comments;
using Core.Domain.Entities.Comments.ValueObjects;
using Core.Domain.Entities.Users.ValueObjects;
using Core.Domain.Entities.Posts.ValueObjects;
using Core.Domain.Entitites.Comments;
using Core.Domain.Entitites.Posts.ValueObjects;
using Core.Domain.Entitites.Users.ValueObjects;
using MediatR;

namespace Forum.Application.Features.Comments.Commands.CreateComment;

public sealed class CreateCommentCommandHandler : IRequestHandler<CreateCommentCommand, ResultT<Unit>>
{
    private readonly ICommentWriteRepository _commentWriteRepository;
  

    public CreateCommentCommandHandler(ICommentWriteRepository commentWriteRepository)
    {
        _commentWriteRepository = commentWriteRepository;
     ;
    }

    public async Task<ResultT<Unit>> Handle(CreateCommentCommand request, CancellationToken cancellationToken)
    {
        var userIdResult = UserId.Create(request.UserId);
      

        var postIdResult = PostId.Create(request.PostId);
       

        var comment = Comment.Create(
            CommentId.NewId(),
            new CommentContent(request.Content),
            userIdResult.Value,
            postIdResult.Value
        );

        if (!comment.IsSuccess)
        {
            return ResultT<Unit>.Failed(comment.Error);
        }
        await _commentWriteRepository.AddAsync(comment.Value);
        return ResultT<Unit>.Success(Unit.Value);
    }


}