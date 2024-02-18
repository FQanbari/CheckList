using CheckList.Shared.Abstractions.Exceptions;

namespace CheckList.Domain.Exceptions;

public class TravelerCheckListIdException : TravelerCheckListException
{
    public TravelerCheckListIdException() : base("Traveler Checklist ID cannot be empty.")
    {
        
    }
}
