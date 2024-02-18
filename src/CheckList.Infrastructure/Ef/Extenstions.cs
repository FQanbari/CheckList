using CheckList.Application.Services;
using CheckList.Domain.Repositories;
using CheckList.Infrastructure.Ef.Contexts;
using CheckList.Infrastructure.Ef.Options;
using CheckList.Infrastructure.Ef.Repositories;
using CheckList.Infrastructure.Ef.Services;
using CheckList.Shared.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CheckList.Infrastructure.Ef;

internal static class Extensions
{
    public static IServiceCollection AddSQLDB(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ITravelerCheckListRepository, TravelerCheckListRepository>();
        services.AddScoped<ITravelerCheckListReadService, TravelerCheckListReadService>();

        var options = configuration.GetOptions<DataBaseOptions>("DataBaseConnectionString");
        services.AddDbContext<ReadDbContext>(ctx =>
        ctx.UseSqlServer(options.ConnectionString));
        services.AddDbContext<WriteDbContext>(ctx =>
            ctx.UseSqlServer(options.ConnectionString));

        return services;
    }
}
