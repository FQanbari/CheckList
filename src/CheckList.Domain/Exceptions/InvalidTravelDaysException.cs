namespace CheckList.Domain.Exceptions;

public class InvalidTravelDaysException : Exception
{
    public ushort Days { get; }
    public InvalidTravelDaysException(ushort days) : base($"Value '{days}' is invalid travel days.")
        => Days = days;
}