using CleanArchitectureGameStore.Application.Common.Mappings;
using CleanArchitectureGameStore.Domain.Entities;

namespace CleanArchitectureGameStore.Application.Features.MainCharacters.Queries.GetAllMainCharacters;

public class GetAllMainCharactersDto : IMapFrom<MainCharacter>
{
    public string Name { get; init; }
    public int Age { get; init; }
    public string HairColor { get; init; }
    public string Race { get; init; }
    public string Gender { get; init; }
    public string Biografia { get; init; }
}