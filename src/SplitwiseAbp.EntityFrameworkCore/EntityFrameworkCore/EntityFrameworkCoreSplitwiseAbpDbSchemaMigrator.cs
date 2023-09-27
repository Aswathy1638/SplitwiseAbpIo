using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SplitwiseAbp.Data;
using Volo.Abp.DependencyInjection;

namespace SplitwiseAbp.EntityFrameworkCore;

public class EntityFrameworkCoreSplitwiseAbpDbSchemaMigrator
    : ISplitwiseAbpDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSplitwiseAbpDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SplitwiseAbpDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SplitwiseAbpDbContext>()
            .Database
            .MigrateAsync();
    }
}
