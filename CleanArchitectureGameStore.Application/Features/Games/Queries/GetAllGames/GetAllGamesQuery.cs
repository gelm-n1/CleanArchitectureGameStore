using MediatR;

namespace CleanArchitectureGameStore.Application.Features.Games.Queries.GetAllGames;

public record GetAllGamesQuery : IRequest<List<GetAllGamesDto>>;
