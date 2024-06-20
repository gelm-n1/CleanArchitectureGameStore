using CleanArchitectureGameStore.Application.Common.Mappings;
using CleanArchitectureGameStore.Domain.Entities;

namespace CleanArchitectureGameStore.Application.Features.Games.Queries.GetAllGames;

public class GetAllGamesDto : IMapFrom<Game>
{
    public string Name { get; init; }
    public DateTime ReleaseDate { get; init; }
    public float Price { get; init; }
}