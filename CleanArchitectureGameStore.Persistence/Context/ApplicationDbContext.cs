using System.Reflection;
using CleanArchitectureGameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureGameStore.Persistence.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
    }
    
    public DbSet<Game> Games => Set<Game>();
    public DbSet<MainCharacter> MainCharacters => Set<MainCharacter>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    
}