using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SplitwiseAbp.Data;

/* This is used if database provider does't define
 * ISplitwiseAbpDbSchemaMigrator implementation.
 */
public class NullSplitwiseAbpDbSchemaMigrator : ISplitwiseAbpDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
