using CheckList.Domain.Exceptions;
using System.Diagnostics.Metrics;

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
