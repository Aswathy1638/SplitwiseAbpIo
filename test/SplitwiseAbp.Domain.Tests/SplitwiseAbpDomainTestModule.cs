using SplitwiseAbp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SplitwiseAbp;

[DependsOn(
    typeof(SplitwiseAbpEntityFrameworkCoreTestModule)
    )]
public class SplitwiseAbpDomainTestModule : AbpModule
{

}
