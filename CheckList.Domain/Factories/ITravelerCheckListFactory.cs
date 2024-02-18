using CheckList.Domain.Consts;
using CheckList.Domain.Entities;
using CheckList.Domain.Policies;
using CheckList.Domain.ValueObjects;

namespace CheckList.Domain.Factories;

public interface ITravelerCheckListFactory
{
    TravelerCheckList Create(TravelerCheckListId id, TravelerCheckListName name, Destination destination);
    TravelerCheckList CreateWithDefaultItems(TravelerCheckListId id, TravelerCheckListName name, TravelDays days, Gender gender, Temperature temperature, Destination destination);
}
public class TravelerCheckListFactory : ITravelerCheckListFactory
{
    private readonly IEnumerable<ITravelerItemsPolicy> _policies;

    public TravelerCheckListFactory(IEnumerable<ITravelerItemsPolicy> policies)
        => _policies = policies;

    public TravelerCheckList Create(TravelerCheckListId id, TravelerCheckListName name, Destination destination)
        => new(id, name, destination);

    public TravelerCheckList CreateWithDefaultItems(TravelerCheckListId id, TravelerCheckListName name, TravelDays days, Gender gender, Temperature temperature, Destination destination)
    {
        var date = new PolicyData(days, gender, temperature, destination);
        var applicablePolicies = _policies.Where(p => p.IsApplicable(date));

        var items = applicablePolicies.SelectMany(p => p.GenerateItems(date));
        var travelerCheckingList = Create(id, name, destination);

        travelerCheckingList.AddItems(items);

        return travelerCheckingList;
    }
}