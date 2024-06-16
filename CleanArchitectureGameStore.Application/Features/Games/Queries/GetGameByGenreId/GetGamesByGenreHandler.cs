using AutoMapper;
using CleanArchitectureGameStore.Application.Interfaces.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureGameStore.Application.Features.Games.Queries.GetGameByGenreId;

public class GetGamesByGenreHandler : IRequestHandler<GetGamesByGenreQuery, List<GetGamesByGenreDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IGameRepository _gameRepository;
    private readonly IMapper _mapper;

    public GetGamesByGenreHandler(IUnitOfWork unitOfWork, IGameRepository gameRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _gameRepository = gameRepository;
        _mapper = mapper;
    }
    
    public async Task<List<GetGamesByGenreDto>> Handle(GetGamesByGenreQuery query, CancellationToken cancellationToken)
    {
        var entities = await _gameRepository.GetGamesByGenreAsync(query.GenreId);
        var games = _mapper.Map<List<GetGamesByGenreDto>>(entities);
        return await Task.FromResult(games);
    }
}