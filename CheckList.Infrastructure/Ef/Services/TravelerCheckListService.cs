using CheckList.Application.Services;
using CheckList.Infrastructure.Ef.Contexts;
using CheckList.Infrastructure.Ef.Models;
using Microsoft.EntityFrameworkCore;

namespace CheckList.Infrastructure.Ef.Services;

internal sealed class TravelerCheckListService : ITravelerCheckListService
{
    private readonly DbSet<TravelerCheckListReadModel> _travelerCheckList;
    public TravelerCheckListService(ReadDbContext readContext)
        => _travelerCheckList = readContext.TravelerCheckList;
    public Task<bool> ExistByName(string name)
        => _travelerCheckList.AnyAsync(x => x.Name == name);
}
