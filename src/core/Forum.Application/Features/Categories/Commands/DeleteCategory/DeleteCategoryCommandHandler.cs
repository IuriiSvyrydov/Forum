using Core.Domain.Common;
using Core.Domain.Common.Errors;
using Core.Domain.Common.Results;
using Core.Domain.Entities.Categories;
using Core.Domain.Entities.Categories.ValueObjects;
using Core.Domain.Entitites.Categories;
using MediatR;

namespace Forum.Application.Features.Categories.Commands.DeleteCategory;

public sealed class DeleteCategoryCommandHandler: IRequestHandler<DeleteCategoryCommand,ResultT<Unit>>
{
    private readonly ICategoryWriteRepository _categoryWriteRepository;
    private readonly ICategoryReadRepository _categoryReadRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteCategoryCommandHandler(ICategoryWriteRepository categoryWriteRepository, ICategoryReadRepository categoryReadRepository, IUnitOfWork unitOfWork)
    {
        _categoryWriteRepository = categoryWriteRepository;
        _categoryReadRepository = categoryReadRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ResultT<Unit>> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
    {
        var categoryId = new CategoryId(request.CategoryId);
        var category = await _categoryReadRepository.GetByIdAsync(categoryId);
        if (category is null)
        {
            return ResultT<Unit>.Failed(Error.NotFound("Category not found","Category not found"));
        }
        await _categoryWriteRepository.DeleteAsync(category,cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return ResultT<Unit>.Success(Unit.Value);
    }
}