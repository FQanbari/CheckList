using CheckList.Domain.Consts;
using CheckList.Shared.Abstractions.Commands;

namespace CheckList.Application.Commands;


public record CreateTravelerCheckListWithItems(Guid id, string Name, ushort Days, Gender Gender, DestinationWriteModel DestinationWithModel) : ICommand;
public record DestinationWriteModel(string City, string Country);
