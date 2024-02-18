using CheckList.Shared.Abstractions.Exceptions;

namespace CheckList.Domain.Exceptions;

public class TravelerItemAlreadyExistsException : TravelerCheckListException
{
    public string ListName { get;}
    public string ItemName { get;}
    public TravelerItemAlreadyExistsException(string listName, string itemName)
        : base($"Traveler checklist: '{listName}' already define item '{itemName}'")
    {
        ListName = listName;
        ItemName = itemName;
    }
}