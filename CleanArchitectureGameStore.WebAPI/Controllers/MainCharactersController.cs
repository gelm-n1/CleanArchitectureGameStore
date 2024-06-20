using CleanArchitectureGameStore.Application.Features.MainCharacters.Commands.CreateMainCharacter;
using CleanArchitectureGameStore.Application.Features.MainCharacters.Commands.DeleteMainCharacter;
using CleanArchitectureGameStore.Application.Features.MainCharacters.Commands.UpdateMainCharacter;
using CleanArchitectureGameStore.Application.Features.MainCharacters.Queries.GetAllMainCharacters;
using CleanArchitectureGameStore.Application.Features.MainCharacters.Queries.GetMainCharacterById;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecureGameStore.WebAPI.Controllers;

public class MainCharactersController : ApiControllerBase
{
    private readonly IMediator _mediator;

    public MainCharactersController(IMediator mediator) => _mediator = mediator;

    [HttpGet]
    public async Task<ActionResult<List<GetAllMainCharactersDto>>> GetAllMainCharacters()
    {
        return await _mediator.Send(new GetAllMainCharactersQuery());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GetMainCharacterByIdDto>> GetMainCharacterId(int id)
    {
        return await _mediator.Send(new GetMainCharacterByIdQuery(id));
    }

    [HttpPost]
    public async Task<ActionResult<MainCharacter>> CreateMainCharacter(CreateMainCharacterCommand command)
    {
        return await _mediator.Send(command);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<MainCharacter>> UpdateMainCharacter(int id, UpdateMainCharacterCommand command)
    {
        if (id != command.Id) return BadRequest();
        return await _mediator.Send(command);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<MainCharacter>> DeleteGame(int id)
    {
        return await _mediator.Send(new DeleteMainCharacterCommand(id));
    }
}