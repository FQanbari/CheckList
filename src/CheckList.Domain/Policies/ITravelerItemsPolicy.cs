using CheckList.Domain.ValueObjects;

namespace CheckList.Domain.Policies;

public interface ITravelerItemsPolicy
{
    bool IsApplicable(PolicyData data);
    IEnumerable<TravelerItem> GenerateItems(PolicyData data);
}
