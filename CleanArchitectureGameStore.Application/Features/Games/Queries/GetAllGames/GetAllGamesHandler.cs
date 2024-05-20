using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArchitectureGameStore.Application.Features.Games.Queries.GetAllGames;
using CleanArchitectureGameStore.Application.Interfaces.Repositories;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureGameStore.Application.Features.Games.Handlers.GetAllGames;

public class GetAllGamesHandler : IRequestHandler<GetAllGamesQuery, List<GetAllGamesDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAllGamesHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<List<GetAllGamesDto>> Handle(GetAllGamesQuery query, CancellationToken cancellationToken)
    {
        var games = await _unitOfWork.Repository<Game>().Entities
            .ProjectTo<GetAllGamesDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);

        return await Task.FromResult(games);
    }
}