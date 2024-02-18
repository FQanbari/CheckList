using CheckList.Shared.Abstractions.Exceptions;

namespace CheckList.Application.Exceptions;

public class TravelerCheckListAlreadyExistsException : TravelerCheckListException
{
    public string Name { get; }
    public TravelerCheckListAlreadyExistsException(string name) : base($"Traveler check list '{name}' already exists.")
        => Name = name;
}