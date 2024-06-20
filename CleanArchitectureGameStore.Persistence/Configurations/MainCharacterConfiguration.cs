using CleanArchitectureGameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitectureGameStore.Persistence.Configurations;

public class MainCharacterConfiguration : IEntityTypeConfiguration<MainCharacter>
{
    public void Configure(EntityTypeBuilder<MainCharacter> builder)
    {
        builder.HasOne(mc => mc.Game)
            .WithOne(g => g.MainCharacter)
            .HasForeignKey<Game>(g => g.MainCharacterId);
    }
}