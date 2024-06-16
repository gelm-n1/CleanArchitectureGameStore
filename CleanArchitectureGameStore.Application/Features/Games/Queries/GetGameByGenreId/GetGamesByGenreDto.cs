using CleanArchitectureGameStore.Application.Common.Mappings;
using CleanArchitectureGameStore.Domain.Entities;

namespace CleanArchitectureGameStore.Application.Features.Games.Queries.GetGameByGenreId;

public class GetGamesByGenreDto : IMapFrom<Game>
{
    public string Name { get; init; }
    public DateTime ReleaseDate { get; init; }
}