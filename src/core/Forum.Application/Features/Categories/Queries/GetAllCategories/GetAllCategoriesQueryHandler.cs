
using AutoMapper;
using Core.Domain.Common.Results;
using MediatR;
using Forum.Application.Features.Categories.Responses;
using Core.Domain.Common.Errors;
using Core.Domain.Entities.Categories;
using Forum.Application.Features.Categories.Queries.GwtAllCategories;

namespace Forum.Application.Features.Categories.Queries.GetAllCategories
{
    public sealed class GetAllCategoriesQueryHandler: IRequestHandler<GetAllCategoriesQuery, ResultT<List<CategoryResponse>>>
    {
        private readonly ICategoryReadRepository _categoryReadRepository;
        private readonly IMapper _mapper;

        public GetAllCategoriesQueryHandler(ICategoryReadRepository categoryReadRepository, IMapper mapper)
        {
            _mapper = mapper;
            _categoryReadRepository = categoryReadRepository;
        }

        public async Task<ResultT<List<CategoryResponse>>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = await _categoryReadRepository.GetAllAsync();
            if (categories is null || !categories.Any())
            {
                return ResultT<List<CategoryResponse>>.Failed(Error.BadRequest("Categories not found","Categories list is empty"));
            }
            return  ResultT<List<CategoryResponse>>.Success(_mapper.Map<List<CategoryResponse>>(categories));
        }
    }
}