using CleanArchitectureGameStore.Application.Features.Games.Commands.DeleteGame;
using MediatR;

namespace CleanArchitectureGameStore.Application.Features.Games.Handlers.DeleteGameHandler;

public class DeleteGameHandler : IRequestHandler<DeleteGameCommand, Task>
{
    public Task<Task> Handle(DeleteGameCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}