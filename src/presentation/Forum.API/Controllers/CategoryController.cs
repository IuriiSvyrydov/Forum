using Forum.Application.Features.Categories.Commands.CreateCategory;
using Forum.Application.Features.Categories.Commands.UpdateCategory;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Forum.Application.Features.Categories.Queries.GetCategory;
using Forum.Application.Features.Categories.Queries.GwtAllCategories;
using Forum.Application.Features.Categories.Commands.DeleteCategory;

namespace Forum.API.Controllers;



[ApiController]
[Route("api/[controller]")]
public class CategoryController:ControllerBase
{
    private readonly IMediator _mediator;
    public CategoryController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<ActionResult> GetAllCategories()
    {
        var result = await _mediator.Send(new GetAllCategoriesQuery());
        return Ok(result);
       
    }
    [HttpGet("{categoryId}")]
    public async Task<ActionResult> GetCategoryById(Guid categoryId)
    {
        var result = await _mediator.Send(new GetCategoryQuery(categoryId));
        return Ok(result);
    }
    [HttpPost]
    public async Task<ActionResult> CreateCategory(CreateCategoryCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }
    [HttpPut]
    public async Task<ActionResult> UpdateCategory(UpdateCategoryCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }
    [HttpDelete("{categoryId}")]
    public async Task<ActionResult> DeleteCategory(Guid categoryId)
    {
        var result = await _mediator.Send(new DeleteCategoryCommand(categoryId));
        return Ok(result);
    }
}