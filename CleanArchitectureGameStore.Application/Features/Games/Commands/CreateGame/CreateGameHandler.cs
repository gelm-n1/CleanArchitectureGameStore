using AutoMapper;
using CleanArchitectureGameStore.Application.Features.Games.Commands.CreateGame;
using CleanArchitectureGameStore.Application.Interfaces.Repositories;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;

namespace CleanArchitectureGameStore.Application.Features.Games.Handlers.CreateGame;

public class CreateGameHandler : IRequestHandler<CreateGameCommand, Game>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateGameHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    
    public async Task<Game> Handle(CreateGameCommand command, CancellationToken cancellationToken)
    {
        var game = new Game()
        {
            Name = command.Name,
            ReleaseDate = command.ReleaseDate
        };

        await _unitOfWork.Repository<Game>().AddAsync(game);
        await _unitOfWork.Save(cancellationToken);
        return await Task.FromResult(game);
    }
}