using MediatR;
using Microsoft.AspNetCore.Mvc;
using Forum.Application.Features.Comments.GetAllComments;
using Forum.Application.Features.Comments.Commands.CreateComment;

namespace Forum.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CommentController:ControllerBase
{
    private readonly IMediator _mediator;
    public CommentController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    public async Task<ActionResult> GetAllComments()
    {
        var result = await _mediator.Send(new GetAllCommentsQuery());
        return Ok(result);
    }
    
    [HttpPost]
    public async Task<ActionResult> CreateComment(CreateCommentCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }
}