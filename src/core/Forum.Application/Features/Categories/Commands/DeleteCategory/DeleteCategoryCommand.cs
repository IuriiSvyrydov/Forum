using Core.Domain.Common.Results;
using MediatR;

namespace Forum.Application.Features.Categories.Commands.DeleteCategory;

public record DeleteCategoryCommand(Guid CategoryId) : IRequest<ResultT<Unit>>;
