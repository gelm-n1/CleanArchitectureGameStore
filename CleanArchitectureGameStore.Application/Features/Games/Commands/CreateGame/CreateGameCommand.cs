using CleanArchitectureGameStore.Application.Common.Mappings;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;

namespace CleanArchitectureGameStore.Application.Features.Games.Commands.CreateGame;

public record CreateGameCommand : IRequest<Game>, IMapFrom<Game>
{
    public string Name { get; set; }
}