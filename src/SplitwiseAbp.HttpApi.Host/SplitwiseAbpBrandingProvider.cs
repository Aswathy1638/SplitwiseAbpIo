using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SplitwiseAbp;

[Dependency(ReplaceServices = true)]
public class SplitwiseAbpBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SplitwiseAbp";
}
