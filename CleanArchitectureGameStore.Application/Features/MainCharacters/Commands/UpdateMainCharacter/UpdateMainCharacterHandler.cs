using CleanArchitectureGameStore.Application.Features.Games.Commands.UpdateGame;
using CleanArchitectureGameStore.Application.Interfaces.Repositories;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureGameStore.Application.Features.MainCharacters.Commands.UpdateMainCharacter;

public class UpdateMainCharacterHandler : IRequestHandler<UpdateMainCharacterCommand, MainCharacter>
{
    private readonly IUnitOfWork _unitOfWork;

    public UpdateMainCharacterHandler(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;
    
    public async Task<MainCharacter> Handle(UpdateMainCharacterCommand command, CancellationToken cancellationToken)
    {
        var mainCharacter = await _unitOfWork.Repository<MainCharacter>().GetByIdAsync(command.Id);

        mainCharacter.Name = command.Name;
        mainCharacter.Age = command.Age;
        mainCharacter.HairColor = command.HairColor;
        mainCharacter.Race = command.Race;
        mainCharacter.Gender = command.Gender;
        mainCharacter.Biografia = command.Biografia;

        await _unitOfWork.Repository<MainCharacter>().UpdateAsync(mainCharacter);
        await _unitOfWork.Save(cancellationToken);
        return await Task.FromResult(mainCharacter);
    }
}