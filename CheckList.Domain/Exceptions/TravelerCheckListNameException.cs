using CheckList.Shared.Abstractions.Exceptions;

namespace CheckList.Domain.Exceptions;

public class TravelerCheckListNameException : TravelerCheckListException
{
    public TravelerCheckListNameException() : base("Traveler Checklist NAME cannot be empty.")
    {
        
    }
}
