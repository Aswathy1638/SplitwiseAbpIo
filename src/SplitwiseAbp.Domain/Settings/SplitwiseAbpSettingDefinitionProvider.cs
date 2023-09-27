using Volo.Abp.Settings;

namespace SplitwiseAbp.Settings;

public class SplitwiseAbpSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SplitwiseAbpSettings.MySetting1));
    }
}
