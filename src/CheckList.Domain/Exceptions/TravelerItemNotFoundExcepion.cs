using CheckList.Shared.Abstractions.Exceptions;

namespace CheckList.Domain.Exceptions;

public class TravelerItemNotFoundExcepion : TravelerCheckListException
{
    public string ItemName { get; }
    public TravelerItemNotFoundExcepion(string itemName) : base($"Travel item '{itemName}' was not found.")
        => ItemName = itemName;
}
