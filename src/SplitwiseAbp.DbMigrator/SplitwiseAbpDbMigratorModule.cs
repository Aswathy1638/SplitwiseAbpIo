using SplitwiseAbp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace SplitwiseAbp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SplitwiseAbpEntityFrameworkCoreModule),
    typeof(SplitwiseAbpApplicationContractsModule)
    )]
public class SplitwiseAbpDbMigratorModule : AbpModule
{
}
