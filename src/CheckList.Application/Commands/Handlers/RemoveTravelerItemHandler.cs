﻿using CheckList.Application.Exceptions;
using CheckList.Domain.Repositories;
using CheckList.Shared.Abstractions.Commands;

namespace CheckList.Application.Commands.Handlers;

public class RemoveTravelerItemHandler : ICommandHandler<RemoveTravelerItem>
{
    private readonly ITravelerCheckListRepository _repository;

    public RemoveTravelerItemHandler(ITravelerCheckListRepository repository)
        => _repository = repository;
    public async Task HandleAsync(RemoveTravelerItem command)
    {
        var travelerCheckingList = await _repository.GetAsync(command.TravelerCheckListId);

        if (travelerCheckingList is null)
        {
            throw new TravelerCheckListNotFound(command.TravelerCheckListId);
        }

        travelerCheckingList.RemoveItem(command.Name);

        await _repository.UpdateAsync(travelerCheckingList);
    }
}