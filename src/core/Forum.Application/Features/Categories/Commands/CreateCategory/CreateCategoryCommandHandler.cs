using AutoMapper;
using Core.Domain.Common.Results;
using Core.Domain.Entities.Categories;
using Core.Domain.Entities.Categories.ValueObjects;
using Core.Domain.Entitites.Categories;
using Forum.Application.Features.Categories.Responses;
using MediatR;

namespace Forum.Application.Features.Categories.Commands.CreateCategory;

public sealed class CreateCategoryCommandHandler: IRequestHandler<CreateCategoryCommand, ResultT<Unit>>
{
    private readonly ICategoryWriteRepository _categoryWriteRepository;
    private readonly IMapper _mapper;

    public CreateCategoryCommandHandler(ICategoryWriteRepository categoryWriteRepository, IMapper mapper)
    {
        _categoryWriteRepository = categoryWriteRepository;
        _mapper = mapper;
    }

    public async Task<ResultT<Unit>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = Category.Create(
            CategoryId.NewId(), 
            new Name(request.Name),
            new Description(request.Description),
            new PostCount(request.PostCount),
            new ImageUrl(request.ImageUrl)
        );
        await _categoryWriteRepository.AddAsync(category);
        
        return ResultT<Unit>.Success(Unit.Value);
    }
}