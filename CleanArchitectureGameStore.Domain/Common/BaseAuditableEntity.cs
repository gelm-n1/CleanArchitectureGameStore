using CleanArchitectureGameStore.Domain.Common.Interfaces;
using CleanArchitectureGameStore.Domain.Common;

namespace CleanArchitectureGameStore.Domain.Common;

public class BaseAuditableEntity : BaseEntity, IAuditableEntity 
{
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}