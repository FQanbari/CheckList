using CheckList.Domain.Exceptions;

namespace CheckList.Domain.ValueObjects;

public record TravelDays
{
    public ushort Value { get; }
    public TravelDays(ushort value)
    {
        if (value is 0 or > 100) throw new InvalidTravelDaysException(value);

        Value = value;
    }

    public static implicit operator ushort(TravelDays id)
        => id.Value;

    public static implicit operator TravelDays(ushort id)
        => new(id);
}
