using CheckList.Application.Exceptions;
using CheckList.Domain.Repositories;
using CheckList.Shared.Abstractions.Commands;

namespace CheckList.Application.Commands.Handlers;

public class TakeItemHandler : ICommandHandler<TakeItem>
{
    private readonly ITravelerCheckListRepository _repository;

    public TakeItemHandler(ITravelerCheckListRepository repository)
        => _repository = repository;
    public async Task HandleAsync(TakeItem command)
    {
        var travelerCheckingList = await _repository.GetAsync(command.TravelerCheckListId);

        if (travelerCheckingList is null)
        {
            throw new TravelerCheckListNotFound(command.TravelerCheckListId);
        }

        travelerCheckingList.TakeItem(command.Name);

        await _repository.UpdateAsync(travelerCheckingList);
    }
}