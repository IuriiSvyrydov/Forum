using AutoMapper;
using MediatR;
using Core.Domain.Common.Results;
using Core.Domain.Entities.Comments;
using Core.Domain.Common.Errors;
using Core.Domain.Common;

namespace Forum.Application.Features.Comments.GetAllComments
{
    public class GetAllCommentsQueryHandler : IRequestHandler<GetAllCommentsQuery, ResultT<List<CommentResponse>>>
    {
       private readonly ICommentReadRepository _commentReadRepository;
       private readonly IMapper _mapper;

       public GetAllCommentsQueryHandler(ICommentReadRepository commentReadRepository, IMapper mapper)
       {
           _commentReadRepository = commentReadRepository;
           _mapper = mapper;
       }

       public async Task<ResultT<List<CommentResponse>>> Handle(GetAllCommentsQuery request, CancellationToken cancellationToken)
        {
            var comments = await _commentReadRepository.GetAllAsync();
            if (comments is null || !comments.Any())
            {
                return ResultT<List<CommentResponse>>.Failed(Error.BadRequest("Comments not found","Comments list is empty"));
            }
            return  ResultT<List<CommentResponse>>.Success(_mapper.Map<List<CommentResponse>>(comments));
        }
    }
}