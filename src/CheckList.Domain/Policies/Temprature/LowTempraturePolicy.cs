using CheckList.Domain.ValueObjects;

namespace CheckList.Domain.Policies.Temprature;

internal sealed class LowTempraturePolicy : ITravelerItemsPolicy
{
    public IEnumerable<TravelerItem> GenerateItems(PolicyData data)
        => new List<TravelerItem>
        {
            new ("Scarf", 1),
            new ("Gloves", 1),
            new ("Jacket", 1),
        };

    public bool IsApplicable(PolicyData data)
        => data.Temperature < 10D;
}