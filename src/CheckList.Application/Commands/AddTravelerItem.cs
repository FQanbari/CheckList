using CheckList.Shared.Abstractions.Commands;

namespace CheckList.Application.Commands;

public record AddTravelerItem(Guid TravelerCheckListId, string Name, uint Quantity):ICommand;
