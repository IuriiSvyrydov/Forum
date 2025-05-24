using Core.Domain.Common.Results;
using Forum.Application.Features.Categories.Responses;
using MediatR;

namespace Forum.Application.Features.Categories.Commands.CreateCategory;

public record CreateCategoryCommand( string Name, string Description, int PostCount,string ImageUrl ) : IRequest<ResultT<Unit>>;
