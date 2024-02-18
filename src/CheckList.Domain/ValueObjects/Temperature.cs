using CheckList.Domain.Exceptions;

namespace CheckList.Domain.ValueObjects;

public record Temperature
{
    public double Value { get; }
    public Temperature(double value)
    {
        if (value is < -100 or > 100) throw new InvalidTempratureException(value);

        Value = value;
    }

    public static implicit operator double(Temperature id)
        => id.Value;

    public static implicit operator Temperature(double id)
        => new(id);
}
