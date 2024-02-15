using CheckList.Domain.Exceptions;

namespace CheckList.Domain.ValueObjects;

public record TravelerItem
{
    public string Name { get; }
    public string Quantity { get; }
    public bool IsTaken { get; init; }

    public TravelerItem(string name, string quantity, bool isTaken)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new TravelerItemNameException();

        Name = name;
        Quantity = quantity;
        IsTaken = isTaken;
    }
}
