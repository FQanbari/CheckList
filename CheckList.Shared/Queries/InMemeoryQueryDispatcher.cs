﻿using CheckList.Shared.Abstractions.Commands;
using CheckList.Shared.Abstractions.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace CheckList.Shared.Queries;

internal sealed class InMemeoryQueryDispatcher : IQueryDispatcher
{
    private readonly IServiceProvider _serviceProvider;

    public InMemeoryQueryDispatcher(IServiceProvider serviceProvider)
        => _serviceProvider = serviceProvider;



    public async Task<TResult> QueryAsync<TResult>(IQuery<TResult> query)
    {
        using var scope = _serviceProvider.CreateScope();
        var handlerType = typeof(IQueryHandler<,>).MakeGenericType(query.GetType(), typeof(TResult));
        var handler = scope.ServiceProvider.GetRequiredService(handlerType);

        return await(Task<TResult>)handlerType.GetMethod(nameof(IQueryHandler<IQuery<TResult>, TResult>.HandleAsync))?
            .Invoke(handler, new[] { query });
    }
}