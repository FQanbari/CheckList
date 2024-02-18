using CheckList.Application.DTO;
using CheckList.Application.Queries;
using CheckList.Infrastructure.Ef.Contexts;
using CheckList.Infrastructure.Ef.Models;
using CheckList.Shared.Abstractions.Queries;
using Microsoft.EntityFrameworkCore;

namespace CheckList.Infrastructure.Ef.Queries.Handler;

internal sealed class SearchTravelerCheckListHandler : IQueryHandler<SearchTravelerCheckList, IEnumerable<TravelerCheckListDto>>
{
    private readonly DbSet<TravelerCheckListReadModel> _TravelerCheckLists;

    public SearchTravelerCheckListHandler(ReadDbContext context)
        => _TravelerCheckLists = context.TravelerCheckList;

    public async Task<IEnumerable<TravelerCheckListDto>> HandleAsync(SearchTravelerCheckList query)
    {
        var dbQuery = _TravelerCheckLists
            .Include(pl => pl.Items)
        .AsQueryable();

        if (query.SearchPhrase is not null)
        {
            dbQuery = dbQuery.Where(pl =>
                Microsoft.EntityFrameworkCore.EF.Functions.Like(pl.Name, $"%{query.SearchPhrase}%"));
        }

        return await dbQuery
            .Select(pl => pl.AsDto())
            .AsNoTracking()
            .ToListAsync();
    }
}