using System.Globalization;
using AutoMapper;
using CleanArchitectureGameStore.Application.Interfaces.Repositories;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;

namespace CleanArchitectureGameStore.Application.Features.Games.Commands.UpdateGame;

public class UpdateGameHandler : IRequestHandler<UpdateGameCommand, Game>
{
    private readonly IUnitOfWork _unitOfWork;

    public UpdateGameHandler(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;
    
    public async Task<Game> Handle(UpdateGameCommand command, CancellationToken cancellationToken)
    {
        var game = await _unitOfWork.Repository<Game>().GetByIdAsync(command.Id);

        game.Name = command.Name;
        game.ReleaseDate = DateTime.ParseExact(command.ReleaseDate, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToUniversalTime();
        game.Price = command.Price;
        
        await _unitOfWork.Repository<Game>().UpdateAsync(game);
        await _unitOfWork.Save(cancellationToken);
        return await Task.FromResult(game);
    }
}