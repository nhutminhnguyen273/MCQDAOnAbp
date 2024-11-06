using Volo.Abp.Settings;

namespace MCQDAOnAbp.ExamResultService.Settings;

public class ExamResultServiceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ExamResultServiceSettings.MySetting1));
    }
}
