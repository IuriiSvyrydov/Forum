using AutoMapper;
using Core.Domain.Common.Errors;
using Core.Domain.Common.Results;
using Core.Domain.Entities.Categories;
using Core.Domain.Entities.Categories.ValueObjects;
using Forum.Application.Features.Categories.Responses;
using MediatR;


namespace Forum.Application.Features.Categories.Queries.GetCategory;

public sealed class GetCategoryQueryHandler: IRequestHandler<GetCategoryQuery, ResultT<CategoryResponse>>
{
    private readonly ICategoryReadRepository _categoryReadRepository;
    private readonly IMapper _mapper;

    public GetCategoryQueryHandler(ICategoryReadRepository categoryReadRepository, IMapper mapper)
    {
        _categoryReadRepository = categoryReadRepository;
        _mapper = mapper;
    }
    public async Task<ResultT<CategoryResponse>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
    {
        var categoryId = new CategoryId(request.CategoryId);
        var category = await _categoryReadRepository.GetByIdAsync(categoryId);
        return category is null ? ResultT<CategoryResponse>.Failed(Error.BadRequest("Category not found","Category not found"))
            : ResultT<CategoryResponse>.Success(_mapper.Map<CategoryResponse>(category));
    }
}