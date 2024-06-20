using CleanArchitectureGameStore.Domain.Common;

namespace CleanArchitectureGameStore.Domain.Entities;

public class Game : BaseAuditableEntity
{
    public string Name { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int? MainCharacterId { get; set; }
    public float Price { get; set; }
    public MainCharacter MainCharacter { get; set; }

}