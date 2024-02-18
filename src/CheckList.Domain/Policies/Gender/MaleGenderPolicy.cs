using CheckList.Domain.ValueObjects;

namespace CheckList.Domain.Policies.Gender;

internal sealed class MaleGenderPolicy : ITravelerItemsPolicy
{
    public IEnumerable<TravelerItem> GenerateItems(PolicyData data)
        => new List<TravelerItem>
        {
            new ("Wallet", 1),
            new ("T-shirt", 5),
            new ("Sleep dress", 1),
        };

    public bool IsApplicable(PolicyData data)
        => data.Gender is Consts.Gender.Female;

}
