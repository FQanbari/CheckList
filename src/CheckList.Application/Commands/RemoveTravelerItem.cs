using CheckList.Shared.Abstractions.Commands;

namespace CheckList.Application.Commands;

public record RemoveTravelerItem(Guid TravelerCheckListId, string Name) : ICommand;  