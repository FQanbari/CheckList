using CheckList.Application.Services;
using CheckList.Infrastructure.Ef.Contexts;
using CheckList.Infrastructure.Ef.Models;
using Microsoft.EntityFrameworkCore;

namespace CheckList.Infrastructure.Ef.Services;

internal sealed class TravelerCheckListReadService : ITravelerCheckListReadService
{
    private readonly DbSet<TravelerCheckListReadModel> _travelerCheckList;
    public TravelerCheckListReadService(ReadDbContext readContext)
        => _travelerCheckList = readContext.TravelerCheckList;
    public Task<bool> ExistsByNameAsync(string name)
        => _travelerCheckList.AnyAsync(x => x.Name == name);
}
