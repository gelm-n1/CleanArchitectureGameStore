using System.Globalization;
using CleanArchitectureGameStore.Application.Interfaces.Repositories;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;

namespace CleanArchitectureGameStore.Application.Features.Games.Commands.CreateGame;

public class CreateGameHandler : IRequestHandler<CreateGameCommand, Game>
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateGameHandler(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;
    
    public async Task<Game> Handle(CreateGameCommand command, CancellationToken cancellationToken)
    {
        var game = new Game()
        {
            Name = command.Name,
            ReleaseDate = DateTime.ParseExact(command.ReleaseDate, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToUniversalTime(),
            Price = command.Price
        };

        await _unitOfWork.Repository<Game>().AddAsync(game);
        await _unitOfWork.Save(cancellationToken);
        return await Task.FromResult(game);
    }
}