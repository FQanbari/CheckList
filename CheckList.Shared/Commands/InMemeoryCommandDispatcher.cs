
using CheckList.Shared.Abstractions.Commands;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Input;

namespace CheckList.Shared.Commands;

internal sealed class InMemeoryCommandDispatcher : ICommandDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public InMemeoryCommandDispatcher(IServiceProvider serviceProvider)
        => _serviceProvider = serviceProvider;

    public async Task DispatchAsync<TCommand>(TCommand command) where TCommand : class, Abstractions.Commands.ICommand
    {
        using var scope = _serviceProvider.CreateScope();
        var handler = scope.ServiceProvider.GetRequiredService<ICommandHandler<TCommand>>();

        await handler.HandleAsync(command);
    }
}
