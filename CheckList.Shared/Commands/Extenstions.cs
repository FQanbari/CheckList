using CheckList.Shared.Abstractions.Commands;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CheckList.Shared.Commands;

public static class Extenstions
{
    public static IServiceCollection AddCommands(this IServiceCollection services)
    {
        var assembly = Assembly.GetCallingAssembly();

        services.AddSingleton<ICommandDispatcher, InMemeoryCommandDispatcher>();
        services.Scan(s => s.FromAssemblies(assembly).AddClasses(c => c.AssignableTo(typeof(ICommandHandler<>)))
        .AsImplementedInterfaces().WithScopedLifetime());

        return services;
    } 
}
