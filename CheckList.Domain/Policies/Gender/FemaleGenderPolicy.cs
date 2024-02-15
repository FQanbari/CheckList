using CheckList.Domain.ValueObjects;

namespace CheckList.Domain.Policies.Gender;

internal sealed class FemaleGenderPolicy : ITravelerItemsPolicy
{
    public IEnumerable<TravelerItem> GenerateItems(PolicyData data)
        => new List<TravelerItem>
        {
            new ("Laptop", 1),
            new ("Bag", 1),
            new ("Book", (uint) Math.Ceiling(data.Days / 7m)),
        };

    public bool IsApplicable(PolicyData data)
        => data.Gender is Consts.Gender.Female;
        
}
