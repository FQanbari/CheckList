using CheckList.Application.DTO.External;
using CheckList.Domain.ValueObjects;

namespace CheckList.Application.Services;

public interface IWeatherService
{
    Task<WeatherDto> GetWeatherAsync(Destination localization);
}
