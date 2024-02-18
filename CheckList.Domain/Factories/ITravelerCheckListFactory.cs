using CheckList.Domain.Consts;
using CheckList.Domain.Entities;
using CheckList.Domain.ValueObjects;

namespace CheckList.Domain.Factories;

public interface ITravelerCheckListFactory
{
    TravelerCheckList Create(TravelerCheckListId id, TravelerCheckListName name, Destination destination);
    TravelerCheckList CreateWithDefaultItems(TravelerCheckListId id, TravelerCheckListName name, TravelDays days, Gender gender, Temperature temperature, Destination destination);
}
