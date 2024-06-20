using CleanArchitectureGameStore.Application.Common.Mappings;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;

namespace CleanArchitectureGameStore.Application.Features.Games.Commands.CreateGame;

public record CreateGameCommand : IRequest<Game>, IMapFrom<Game>
{
    public string Name { get; set; }
    public string ReleaseDate { get; set; }
    public float Price { get; set; }
    
}