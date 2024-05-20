using CleanArchitectureGameStore.Domain.Entities;

namespace CleanArchitectureGameStore.Application.Interfaces.Repositories;

public interface IGameRepository
{
    Task<List<Game>> GetGamesByGenreAsync(int genreId);
}