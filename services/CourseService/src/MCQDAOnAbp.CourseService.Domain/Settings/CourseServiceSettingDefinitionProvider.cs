using Volo.Abp.Settings;

namespace MCQDAOnAbp.CourseService.Settings;

public class CourseServiceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CourseServiceSettings.MySetting1));
    }
}
