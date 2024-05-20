using MediatR;

namespace CleanArchitectureGameStore.Application.Features.Games.Queries.GetGameById;

public record GetGameByIdQuery(int Id) : IRequest<GetGameByIdDto>;