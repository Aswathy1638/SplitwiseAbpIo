using Volo.Abp.Modularity;

namespace SplitwiseAbp;

[DependsOn(
    typeof(SplitwiseAbpApplicationModule),
    typeof(SplitwiseAbpDomainTestModule)
    )]
public class SplitwiseAbpApplicationTestModule : AbpModule
{

}
