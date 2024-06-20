using CleanArchitectureGameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitectureGameStore.Persistence.Configurations;

public class GameConfiguration : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder.HasOne(g => g.MainCharacter)
            .WithOne(mc => mc.Game)
            .HasForeignKey<MainCharacter>(mc => mc.GameId);
    }
}