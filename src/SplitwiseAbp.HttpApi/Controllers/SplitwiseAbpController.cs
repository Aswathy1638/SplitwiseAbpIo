using SplitwiseAbp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SplitwiseAbp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SplitwiseAbpController : AbpControllerBase
{
    protected SplitwiseAbpController()
    {
        LocalizationResource = typeof(SplitwiseAbpResource);
    }
}
