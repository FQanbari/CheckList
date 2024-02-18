using CheckList.Domain.ValueObjects;
using CheckList.Shared.Abstractions.Exceptions;

namespace CheckList.Application.Exceptions;

public class MissingDestinationWeatherException : TravelerCheckListException
{
    public Destination Destination { get; }
    public MissingDestinationWeatherException(Destination destination) : base($"Couldn't featch weather data for destination '{destination.Country}/{destination.City}'.")
        => Destination = destination;
}