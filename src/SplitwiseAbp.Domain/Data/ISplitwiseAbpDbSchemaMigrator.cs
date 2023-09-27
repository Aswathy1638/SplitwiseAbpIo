using System.Threading.Tasks;

namespace SplitwiseAbp.Data;

public interface ISplitwiseAbpDbSchemaMigrator
{
    Task MigrateAsync();
}
