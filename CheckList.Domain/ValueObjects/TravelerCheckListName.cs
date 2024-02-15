using CheckList.Domain.Exceptions;

namespace CheckList.Domain.ValueObjects;

public record TravelerCheckListName
{
    public string Value { get; }
    public TravelerCheckListName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new TravelerCheckListNameException();

        Value = value.Trim();
    }

    public static implicit operator string(TravelerCheckListName name)
        => name.Value;

    public static implicit operator TravelerCheckListName(string name)
        => new(name);
}

public record Destination
{
    public string Value { get; }
    public Destination(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new TravelerCheckListDestinationException();

        Value = value.Trim();
    }

    public static implicit operator string(Destination name)
        => name.Value;

    public static implicit operator Destination(string name)
        => new(name);
}