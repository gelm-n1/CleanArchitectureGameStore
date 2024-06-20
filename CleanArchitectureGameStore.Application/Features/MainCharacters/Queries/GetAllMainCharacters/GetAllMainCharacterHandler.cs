using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArchitectureGameStore.Application.Interfaces.Repositories;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureGameStore.Application.Features.MainCharacters.Queries.GetAllMainCharacters;

public class GetAllMainCharacterHandler : IRequestHandler<GetAllMainCharactersQuery, List<GetAllMainCharactersDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllMainCharacterHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    
    public async Task<List<GetAllMainCharactersDto>> Handle(GetAllMainCharactersQuery request, CancellationToken cancellationToken)
    {
        var mainCharacters = await _unitOfWork.Repository<MainCharacter>().Entities
            .ProjectTo<GetAllMainCharactersDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);

        return await Task.FromResult(mainCharacters);
    }
}