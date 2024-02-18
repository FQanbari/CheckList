
using CheckList.Domain.Entities;
using CheckList.Domain.Repositories;
using CheckList.Domain.ValueObjects;
using CheckList.Infrastructure.Ef.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CheckList.Infrastructure.Ef.Repositories;

public class TravelerCheckListRepository : ITravelerCheckListRepository
{
    private readonly DbSet<TravelerCheckList> _travelCheckList;
    private readonly WriteDbContext _writeDbContext;

    public TravelerCheckListRepository(WriteDbContext writeDbContext)
    {
        _writeDbContext = writeDbContext;
        _travelCheckList = writeDbContext.TravelerCheckLists;
    }
    public async Task AddAsync(TravelerCheckList travelerCheckList)
    {
        await _travelCheckList.AddAsync(travelerCheckList);
        await _writeDbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(TravelerCheckList travelerCheckList)
    {
        _travelCheckList.Remove(travelerCheckList);
        await _writeDbContext.SaveChangesAsync();
    }

    public async Task<TravelerCheckList> GetAsync(TravelerCheckListId id)
         => await _travelCheckList.Include("_item").SingleOrDefaultAsync(pl => pl.Id == id);

    public async Task UpdateAsync(TravelerCheckList travelerCheckList)
    {
        _travelCheckList.Update(travelerCheckList);
        await _writeDbContext.SaveChangesAsync();
    }

}
