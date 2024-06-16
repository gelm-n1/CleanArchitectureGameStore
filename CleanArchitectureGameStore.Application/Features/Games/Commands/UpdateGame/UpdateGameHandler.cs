using AutoMapper;
using CleanArchitectureGameStore.Application.Interfaces.Repositories;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;

namespace CleanArchitectureGameStore.Application.Features.Games.Commands.UpdateGame;

public class UpdateGameHandler : IRequestHandler<UpdateGameCommand, Game>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateGameHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    
    public async Task<Game> Handle(UpdateGameCommand command, CancellationToken cancellationToken)
    {
        var game = await _unitOfWork.Repository<Game>().GetByIdAsync(command.Id);

        game.Name = command.Name;
        game.ReleaseDate = command.ReleaseDate;

        await _unitOfWork.Repository<Game>().UpdateAsync(game);
        await _unitOfWork.Save(cancellationToken);
        return await Task.FromResult(game);
    }
}