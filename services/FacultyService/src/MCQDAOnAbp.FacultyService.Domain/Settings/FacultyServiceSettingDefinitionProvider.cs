using Volo.Abp.Settings;

namespace MCQDAOnAbp.FacultyService.Settings;

public class FacultyServiceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(FacultyServiceSettings.MySetting1));
    }
}
