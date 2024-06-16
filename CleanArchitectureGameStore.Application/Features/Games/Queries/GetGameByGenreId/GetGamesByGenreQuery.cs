using MediatR;

namespace CleanArchitectureGameStore.Application.Features.Games.Queries.GetGameByGenreId;

public record GetGamesByGenreQuery : IRequest<List<GetGamesByGenreDto>>
{
    public int GenreId { get; set; }
    
    public GetGamesByGenreQuery() {}

    public GetGamesByGenreQuery(int genreId) => GenreId = genreId;
}
