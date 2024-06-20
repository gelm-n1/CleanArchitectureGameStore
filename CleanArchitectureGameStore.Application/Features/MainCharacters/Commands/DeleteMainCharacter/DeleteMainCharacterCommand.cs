using CleanArchitectureGameStore.Application.Common.Mappings;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;

namespace CleanArchitectureGameStore.Application.Features.MainCharacters.Commands.DeleteMainCharacter;

public class DeleteMainCharacterCommand : IRequest<MainCharacter>, IMapFrom<MainCharacter>
{
    public int Id { get; set; }
    
    public DeleteMainCharacterCommand() {}

    public DeleteMainCharacterCommand(int id) => Id = id;
}