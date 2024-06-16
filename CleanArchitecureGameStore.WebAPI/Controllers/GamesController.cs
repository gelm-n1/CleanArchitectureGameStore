using CleanArchitectureGameStore.Application.Features.Games.Commands.CreateGame;
using CleanArchitectureGameStore.Application.Features.Games.Commands.DeleteGame;
using CleanArchitectureGameStore.Application.Features.Games.Commands.UpdateGame;
using CleanArchitectureGameStore.Application.Features.Games.Queries.GetAllGames;
using CleanArchitectureGameStore.Application.Features.Games.Queries.GetGameByGenreId;
using CleanArchitectureGameStore.Application.Features.Games.Queries.GetGameById;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecureGameStore.WebAPI.Controllers;

public class GamesController : ApiControllerBase
{
    private readonly IMediator _mediator;

    public GamesController(IMediator mediator) => _mediator = mediator;

    [HttpGet]
    public async Task<ActionResult<List<GetAllGamesDto>>> GetAllGames()
    {
        return await _mediator.Send(new GetAllGamesQuery());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GetGameByIdDto>> GetGameById(int id)
    {
        return await _mediator.Send(new GetGameByIdQuery(id));
    }

    [HttpGet]
    [Route("genre/{genreId}")]
    public async Task<ActionResult<List<GetGamesByGenreDto>>> GetGamesByGenre(int genreId)
    {
        return await _mediator.Send(new GetGamesByGenreQuery(genreId));
    }

    [HttpPost]
    public async Task<ActionResult<Game>> CreateGame(CreateGameCommand command)
    {
        return await _mediator.Send(command);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Game>> UpdateGame(int id, UpdateGameCommand command)
    {
        if (id != command.Id) return BadRequest();
        return await _mediator.Send(command);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Game>> DeleteGame(int id)
    {
        return await _mediator.Send(new DeleteGameCommand(id));
    }
    
}