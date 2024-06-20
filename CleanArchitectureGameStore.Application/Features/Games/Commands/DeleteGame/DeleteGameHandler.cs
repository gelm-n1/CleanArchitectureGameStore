using CleanArchitectureGameStore.Application.Interfaces.Repositories;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;

namespace CleanArchitectureGameStore.Application.Features.Games.Commands.DeleteGame;

public class DeleteGameHandler : IRequestHandler<DeleteGameCommand, Game>
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteGameHandler(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;
    
    public async Task<Game> Handle(DeleteGameCommand command, CancellationToken cancellationToken)
    {
        var game = await _unitOfWork.Repository<Game>().GetByIdAsync(command.Id);

        await _unitOfWork.Repository<Game>().DeleteAsync(game);
        await _unitOfWork.Save(cancellationToken);
        return await Task.FromResult(game);
    }
}