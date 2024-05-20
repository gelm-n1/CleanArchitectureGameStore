using CleanArchitectureGameStore.Application.Common.Mappings;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;

namespace CleanArchitectureGameStore.Application.Features.Games.Commands.DeleteGame;

public class DeleteGameCommand(int Id) : IRequest<Task>, IMapFrom<Game>;