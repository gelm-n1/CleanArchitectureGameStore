using MediatR;

namespace CleanArchitectureGameStore.Application.Features.MainCharacters.Queries.GetMainCharacterById;

public record GetMainCharacterByIdQuery(int Id) : IRequest<GetMainCharacterByIdDto>;