using CheckList.Shared.Abstractions.Exceptions;

namespace CheckList.Application.Exceptions;

public class TravelerCheckListNotFound : TravelerCheckListException
{
    public Guid Id { get; }
    public TravelerCheckListNotFound(Guid id) : base($"Traveler check list with ID '{id}' was not found.")
        => Id = id;
}
