using CleanArchitectureGameStore.Application.Common.Mappings;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;

namespace CleanArchitectureGameStore.Application.Features.MainCharacters.Commands.CreateMainCharacter;

public class CreateMainCharacterCommand : IRequest<MainCharacter>, IMapFrom<MainCharacter>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string HairColor { get; set; }
    public string Race { get; set; }
    public string Gender { get; set; }
    public string Biografia { get; set; }
}