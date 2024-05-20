using CleanArchitectureGameStore.Domain.Common;

namespace CleanArchitectureGameStore.Domain.Entities;

public class Game : BaseAuditableEntity
{
    public string Name { get; set; }
    public int? GenreId { get; set; }
    public DateTime ReleaseDate { get; set; }
}