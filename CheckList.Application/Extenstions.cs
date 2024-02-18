using CheckList.Domain.Factories;
using Microsoft.Extensions.DependencyInjection;
using CheckList.Shared.Commands;
using CheckList.Domain.Policies;

namespace CheckList.Application;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddCommands();
        services.AddSingleton<ITravelerCheckListFactory, TravelerCheckListFactory>();

        services.Scan(b => b.FromAssemblies(typeof(ITravelerItemsPolicy).Assembly)
            .AddClasses(c => c.AssignableTo<ITravelerItemsPolicy>())
            .AsImplementedInterfaces()
            .WithSingletonLifetime());

        return services;
    }
}