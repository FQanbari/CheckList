using CheckList.Domain.Entities;
using CheckList.Domain.ValueObjects;

namespace CheckList.Domain.Repositories;

public interface ITravelerCheckListRepository
{
    Task<TravelerCheckList> GetAsync(TravelerCheckListId id);
    Task AddAsync(TravelerCheckList travelerCheckList);
    Task UpdateAsync(TravelerCheckList travelerCheckList);
    Task DeleteAsync(TravelerCheckList travelerCheckList);
}
