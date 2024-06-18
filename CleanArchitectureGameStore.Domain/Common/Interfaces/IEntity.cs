using System.ComponentModel.DataAnnotations;

namespace CleanArchitectureGameStore.Domain.Common.Interfaces;

public interface IEntity
{
    [Key]
    public int Id { get; set; }
}