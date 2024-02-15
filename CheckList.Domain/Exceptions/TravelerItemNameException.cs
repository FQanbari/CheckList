using CheckList.Shared.Abstractions.Exceptions;

namespace CheckList.Domain.Exceptions;

public class TravelerItemNameException : TravelerCheckListException
{
    public TravelerItemNameException() : base("Traveler item name cannot be empty.")
    {
        
    }
}