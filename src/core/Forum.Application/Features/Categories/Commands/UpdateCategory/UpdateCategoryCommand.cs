using Core.Domain.Common.Results;
using Forum.Application.Features.Categories.Responses;
using MediatR;

namespace Forum.Application.Features.Categories.Commands.UpdateCategory;

public record UpdateCategoryCommand(Guid CategoryId,string Name,string Description,
    int PostCount,string ImageUrl) : IRequest<ResultT<UpdateCategoryResponse>>;
