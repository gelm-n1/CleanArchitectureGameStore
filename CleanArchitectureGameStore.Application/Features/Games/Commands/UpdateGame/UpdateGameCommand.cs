using CleanArchitectureGameStore.Domain.Entities;
using MediatR;

namespace CleanArchitectureGameStore.Application.Features.Games.Commands.UpdateGame;

public class UpdateGameCommand : IRequest<Game>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime ReleaseDate { get; set; }
}