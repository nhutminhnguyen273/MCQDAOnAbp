using Volo.Abp.Settings;

namespace MCQDAOnAbp.QuestionBankService.Settings;

public class QuestionBankServiceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(QuestionBankServiceSettings.MySetting1));
    }
}
