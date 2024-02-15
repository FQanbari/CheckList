using CheckList.Domain.ValueObjects;

namespace CheckList.Domain.Policies.Temprature;

internal sealed class HighTempraturePolicy : ITravelerItemsPolicy
{
    public IEnumerable<TravelerItem> GenerateItems(PolicyData data)
        => new List<TravelerItem>
        {
            new ("Hat", 1),
            new ("Sunglasses", 1),
            new ("sun cream", 1),
        };

    public bool IsApplicable(PolicyData data)
        => data.Temperature > 25D;
}
