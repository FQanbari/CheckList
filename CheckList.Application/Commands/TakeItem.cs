using CheckList.Shared.Abstractions.Commands;

namespace CheckList.Application.Commands;


public record TakeItem(Guid TravelerCheckListId, string Name) : ICommand;
