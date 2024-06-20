using CleanArchitectureGameStore.Application.Interfaces.Repositories;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;

namespace CleanArchitectureGameStore.Application.Features.MainCharacters.Commands.DeleteMainCharacter;

public class DeleteMainCharacterHandler : IRequestHandler<DeleteMainCharacterCommand, MainCharacter>
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteMainCharacterHandler(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;
    
    public async Task<MainCharacter> Handle(DeleteMainCharacterCommand command, CancellationToken cancellationToken)
    {
        var mainCharacter = await _unitOfWork.Repository<MainCharacter>().GetByIdAsync(command.Id);

        await _unitOfWork.Repository<MainCharacter>().DeleteAsync(mainCharacter);
        await _unitOfWork.Save(cancellationToken);
        return await Task.FromResult(mainCharacter);
    }
}