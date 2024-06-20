using System.Dynamic;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;

namespace CleanArchitectureGameStore.Application.Features.MainCharacters.Commands.UpdateMainCharacter;

public class UpdateMainCharacterCommand : IRequest<MainCharacter>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string HairColor { get; set; }
    public string Race { get; set; }
    public string Gender { get; set; }
    public string Biografia { get; set; }
}