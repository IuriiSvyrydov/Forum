using AutoMapper;
using Core.Domain.Common;
using Core.Domain.Common.Errors;
using Core.Domain.Common.Results;
using Core.Domain.Entities.Categories;
using Core.Domain.Entities.Categories.ValueObjects;
using Core.Domain.Entitites.Categories;
using Forum.Application.Features.Categories.Responses;
using MediatR;

namespace Forum.Application.Features.Categories.Commands.UpdateCategory;

public sealed class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, ResultT<UpdateCategoryResponse>>
{
    private readonly ICategoryWriteRepository _categoryWriteRepository;
    private readonly ICategoryReadRepository _categoryReadRepository;
    private readonly IMapper _mapper;

    private readonly IUnitOfWork _unitOfWork;

    public UpdateCategoryCommandHandler(ICategoryWriteRepository categoryWriteRepository, IMapper mapper, IUnitOfWork unitOfWork,
        ICategoryReadRepository categoryReadRepository)
    {
        _categoryWriteRepository = categoryWriteRepository;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _categoryReadRepository = categoryReadRepository;
    }
    public async Task<ResultT<UpdateCategoryResponse>> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        var categoryId = new CategoryId(request.CategoryId);
        var category = await _categoryReadRepository.GetByIdAsync(categoryId,cancellationToken);
        if (category is null)
        {
            return ResultT<UpdateCategoryResponse>.Failed(Error.BadRequest("Category not found","Category not found"));
        }
        await _categoryWriteRepository.UpdateAsync(category,cancellationToken);
        var response = _mapper.Map<UpdateCategoryResponse>(category);
  
        return ResultT<UpdateCategoryResponse>.Success(response);
        
    }
}