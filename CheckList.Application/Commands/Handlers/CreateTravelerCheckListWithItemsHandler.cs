﻿using CheckList.Application.Exceptions;
using CheckList.Application.Services;
using CheckList.Domain.Factories;
using CheckList.Domain.Repositories;
using CheckList.Domain.ValueObjects;
using CheckList.Shared.Abstractions.Commands;

namespace CheckList.Application.Commands.Handlers;

public class CreateTravelerCheckListWithItemsHandler : ICommandHandler<CreateTravelerCheckListWithItems>
{
    private readonly ITravelerCheckListRepository _repository;
    private readonly ITravelerCheckListFactory _factory;
    private readonly IWeatherService _service;

    public CreateTravelerCheckListWithItemsHandler(ITravelerCheckListRepository repository, ITravelerCheckListFactory factory, IWeatherService weatherService)
    {
        _repository = repository;
        _factory = factory;
        _service = weatherService;
    }

    public async Task HandleAsync(CreateTravelerCheckListWithItems command)
    {
        var (id, name, days, gender, DestinationWriteModel) = command;

        var destination = new Destination(command.Name, DestinationWriteModel.Country);
        var weather = await _service.GetWeatherAsync(destination);

        if (weather is null)
        {
            throw new MissingDestinationWeatherException(destination);
        }

        var TraveleCheckList = _factory.CreateWithDefaultItems(id, name, days, gender, weather.Tamperature, destination);

        await _repository.AddAsync(TraveleCheckList);
    }
}