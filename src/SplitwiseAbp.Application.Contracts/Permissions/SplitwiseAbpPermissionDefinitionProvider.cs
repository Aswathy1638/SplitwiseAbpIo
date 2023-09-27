using SplitwiseAbp.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SplitwiseAbp.Permissions;

public class SplitwiseAbpPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SplitwiseAbpPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SplitwiseAbpPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SplitwiseAbpResource>(name);
    }
}
