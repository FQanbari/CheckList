using CheckList.Application.DTO;
using CheckList.Application.Queries;
using CheckList.Domain.Repositories;
using CheckList.Infrastructure.Ef.Contexts;
using CheckList.Infrastructure.Ef.Models;
using CheckList.Shared.Abstractions.Queries;
using Microsoft.EntityFrameworkCore;

namespace CheckList.Infrastructure.Ef.Queries.Handler;

public class GetTravelerCheckListHandler : IQueryHandler<GetTravelerCheckList, TravelerCheckListDto>
{
    private readonly DbSet<TravelerCheckListReadModel> _travelCheckList;

    public GetTravelerCheckListHandler(ReadDbContext context)
    {
        _travelCheckList = context.TravelerCheckList;
    }
    public async Task<TravelerCheckListDto> HandleAsync(GetTravelerCheckList query)
        => await _travelCheckList
            .Include(pl => pl.Name)
            .Where(pl => pl.Id == query.Id)
            .Select(pl => pl.AsDto())
            .AsNoTracking()
            .SingleOrDefaultAsync();
}
