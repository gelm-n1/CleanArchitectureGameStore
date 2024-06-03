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
    
    
}