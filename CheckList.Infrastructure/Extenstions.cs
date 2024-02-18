using CheckList.Application.Services;
using CheckList.Infrastructure.Ef;
using CheckList.Infrastructure.Logging;
using CheckList.Infrastructure.Services;
using CheckList.Shared.Abstractions.Commands;
using CheckList.Shared.Queries;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CheckList.Infrastructure;

public static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSQLDB(configuration);
        services.AddQueries();
        services.AddSingleton<IWeatherService, DumbWeatherService>();

        services.TryDecorate(typeof(ICommandHandler<>), typeof(LoggingCommandHandlerDecorator<>));

        return services;
    }
}
