using AutoMapper;
using CleanArchitectureGameStore.Application.Interfaces.Repositories;
using CleanArchitectureGameStore.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureGameStore.Application.Features.Games.Queries.GetGameById;

public class GetGameByIdHandler : IRequestHandler<GetGameByIdQuery, GetGameByIdDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetGameByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public async Task<GetGameByIdDto> Handle(GetGameByIdQuery query, CancellationToken cancellationToken)
    {
        var entity = await _unitOfWork.Repository<Game>().GetByIdAsync(query.Id);
        var game = _mapper.Map<GetGameByIdDto>(entity);
        return await Task.FromResult(game);
    }
}