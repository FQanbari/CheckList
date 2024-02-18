using CheckList.Application.Exceptions;
using CheckList.Domain.Repositories;
using CheckList.Shared.Abstractions.Commands;

namespace CheckList.Application.Commands.Handlers;

public class RemoveTravelerCheckListHandler : ICommandHandler<RemoveTravelerCheckList>
{
    private readonly ITravelerCheckListRepository _repository;

    public RemoveTravelerCheckListHandler(ITravelerCheckListRepository repository)
        => _repository = repository;
    public async Task HandleAsync(RemoveTravelerCheckList command)
    {
        var travelerCheckingList = await _repository.GetAsync(command.Id);

        if (travelerCheckingList is null)
        {
            throw new TravelerCheckListNotFound(command.Id);
        }
       
        await _repository.DeleteAsync(travelerCheckingList);
    }
}