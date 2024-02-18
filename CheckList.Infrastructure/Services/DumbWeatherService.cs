using CheckList.Application.DTO.External;
using CheckList.Application.Services;
using CheckList.Domain.ValueObjects;

namespace CheckList.Infrastructure.Services;

internal sealed class DumbWeatherService : IWeatherService
{
    public async Task<WeatherDto> GetWeatherAsync(Destination localization)
        => await Task.FromResult(new WeatherDto(new Random().Next(5, 30)));
}
