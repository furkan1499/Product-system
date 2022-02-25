using Volo.Abp.Settings;

namespace ProductSystem.Settings;

public class ProductSystemSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ProductSystemSettings.MySetting1));
    }
}
