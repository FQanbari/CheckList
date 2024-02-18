using CheckList.Shared.Abstractions.Exceptions;

namespace CheckList.Domain.Exceptions;

public class InvalidTempratureException : TravelerCheckListException
{
    public double Value { get; }
    public InvalidTempratureException(double value) : base($"Value '{value}' is invalid temprature.")
    {
        Value = value;
    }
}