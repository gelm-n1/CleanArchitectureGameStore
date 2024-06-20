using CleanArchitectureGameStore.Domain.Common;

namespace CleanArchitectureGameStore.Domain.Entities;

public class MainCharacter : BaseAuditableEntity
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string HairColor { get; set; }
    public string Race { get; set; }
    public string Gender { get; set; }
    public string Biografia { get; set; }
    public int GameId { get; set; }
    public Game Game { get; set; }
}