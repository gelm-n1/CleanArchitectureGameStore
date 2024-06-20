using AutoMapper;
using CleanArchitectureGameStore.Application.Interfaces.Repositories;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;

namespace CleanArchitectureGameStore.Application.Features.MainCharacters.Commands.CreateMainCharacter;

public class CreateMainCharacterHandler : IRequestHandler<CreateMainCharacterCommand, MainCharacter>
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateMainCharacterHandler(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;
    
    
    
    public async Task<MainCharacter> Handle(CreateMainCharacterCommand command, CancellationToken cancellationToken)
    {
        var mainCharacter = new MainCharacter()
        {
            Name = command.Name,
            Age = command.Age,
            HairColor = command.HairColor,
            Race = command.Race,
            Gender = command.Gender,
            Biografia = command.Biografia
        };

        await _unitOfWork.Repository<MainCharacter>().AddAsync(mainCharacter);
        await _unitOfWork.Save(cancellationToken);
        return await Task.FromResult(mainCharacter);
    }
}
