using AutoMapper;
using CleanArchitectureGameStore.Application.Interfaces.Repositories;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;

namespace CleanArchitectureGameStore.Application.Features.MainCharacters.Queries.GetMainCharacterById;

public class GetMainCharacterByIdHandler : IRequestHandler<GetMainCharacterByIdQuery, GetMainCharacterByIdDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetMainCharacterByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    
    public async Task<GetMainCharacterByIdDto> Handle(GetMainCharacterByIdQuery query, CancellationToken cancellationToken)
    {
        var entity = await _unitOfWork.Repository<MainCharacter>().GetByIdAsync(query.Id);
        var mainCharacter = _mapper.Map<GetMainCharacterByIdDto>(entity);
        return await Task.FromResult(mainCharacter);
    }
}