using CheckList.Shared.Abstractions.Commands;

namespace CheckList.Application.Commands;


public record RemoveTravelerCheckList(Guid Id) : ICommand;