using Microsoft.Extensions.Localization;
using MCQDAOnAbp.QuestionBankService.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MCQDAOnAbp.QuestionBankService.Web;

[Dependency(ReplaceServices = true)]
public class QuestionBankServiceBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<QuestionBankServiceResource> _localizer;

    public QuestionBankServiceBrandingProvider(IStringLocalizer<QuestionBankServiceResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
