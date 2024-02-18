using CheckList.Shared.Abstractions.Exceptions;

namespace CheckList.Domain.Exceptions;

public class TravelerCheckListDestinationException : TravelerCheckListException
{
    public TravelerCheckListDestinationException() : base("Traveler Checklist DESTINATION cannot be empty.")
    {

    }
}