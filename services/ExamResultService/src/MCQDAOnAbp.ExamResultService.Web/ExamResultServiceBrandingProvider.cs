using Microsoft.Extensions.Localization;
using MCQDAOnAbp.ExamResultService.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MCQDAOnAbp.ExamResultService.Web;

[Dependency(ReplaceServices = true)]
public class ExamResultServiceBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ExamResultServiceResource> _localizer;

    public ExamResultServiceBrandingProvider(IStringLocalizer<ExamResultServiceResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
