
using Core.Domain.Common.Results;
using Forum.Application.Features.Categories.Responses;
using MediatR;

namespace Forum.Application.Features.Categories.Queries.GwtAllCategories;

public record GetAllCategoriesQuery(): IRequest<ResultT<List<CategoryResponse>>>;

