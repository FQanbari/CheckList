using CheckList.Shared.Abstractions.Exceptions;

namespace CheckList.Domain.Exceptions;

public class TravelerItemAlreadyExitstException : TravelerCheckListException
{
    public string ListName { get;}
    public string ItemName { get;}
    public TravelerItemAlreadyExitstException(string listName, string itemName)
        : base($"Traveler checklist: '{listName}' already define item '{itemName}'")
    {
        ListName = listName;
        ItemName = itemName;
    }
}