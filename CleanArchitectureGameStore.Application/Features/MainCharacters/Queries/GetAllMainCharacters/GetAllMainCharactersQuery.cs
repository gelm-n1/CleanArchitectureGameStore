using MediatR;

namespace CleanArchitectureGameStore.Application.Features.MainCharacters.Queries.GetAllMainCharacters;

public record GetAllMainCharactersQuery : IRequest<List<GetAllMainCharactersDto>>;