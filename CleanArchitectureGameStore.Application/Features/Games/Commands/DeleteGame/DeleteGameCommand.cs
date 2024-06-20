using CleanArchitectureGameStore.Application.Common.Mappings;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;

namespace CleanArchitectureGameStore.Application.Features.Games.Commands.DeleteGame;

public class DeleteGameCommand : IRequest<Game>, IMapFrom<Game>
{
    public int Id { get; set; }

    public DeleteGameCommand() {}

    public DeleteGameCommand(int id) => Id = id;
    
}