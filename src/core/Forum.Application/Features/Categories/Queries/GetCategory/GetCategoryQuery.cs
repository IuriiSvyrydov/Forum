using Core.Domain.Common.Results;
using Forum.Application.Features.Categories.Responses;
using MediatR;

namespace Forum.Application.Features.Categories.Queries.GetCategory;

public record GetCategoryQuery(Guid CategoryId): IRequest<ResultT<CategoryResponse>>;
