using CleanArchitectureGameStore.Application.Common.Mappings;
using CleanArchitectureGameStore.Domain.Entities;

namespace CleanArchitectureGameStore.Application.Features.Games.Queries.GetGameById;

public class GetGameByIdDto : IMapFrom<Game>
{
    public string Name { get; init; }
    public DateTime ReleaseDate { get; init; }
    public float Price { get; init; }
}