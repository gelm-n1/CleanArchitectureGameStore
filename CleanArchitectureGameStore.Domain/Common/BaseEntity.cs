using CleanArchitectureGameStore.Domain.Common.Interfaces;

namespace CleanArchitectureGameStore.Domain.Common;

public class BaseEntity : IEntity
{
    public int Id { get; set; }
}