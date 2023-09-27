using System;
using System.Collections.Generic;
using System.Text;
using SplitwiseAbp.Localization;
using Volo.Abp.Application.Services;

namespace SplitwiseAbp;

/* Inherit your application services from this class.
 */
public abstract class SplitwiseAbpAppService : ApplicationService
{
    protected SplitwiseAbpAppService()
    {
        LocalizationResource = typeof(SplitwiseAbpResource);
    }
}
