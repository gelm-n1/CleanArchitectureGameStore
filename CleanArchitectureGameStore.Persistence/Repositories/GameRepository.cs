using CleanArchitectureGameStore.Application.Interfaces.Repositories;
using CleanArchitectureGameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureGameStore.Persistence.Repositories;

public class GameRepository : IGameRepository
{
    private readonly IGenericRepository<Game> _repoitory;

    public GameRepository(IGenericRepository<Game> repository)
    {
        _repoitory = repository;
    }
    
    public async Task<List<Game>> GetGamesByGenreAsync(int genreId)
    {
        return await _repoitory.Entities.Where(x => x.GenreId == genreId).ToListAsync();
    }
}