using Microsoft.Extensions.Localization;
using MCQDAOnAbp.TrainingProgramService.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MCQDAOnAbp.TrainingProgramService.Web;

[Dependency(ReplaceServices = true)]
public class TrainingProgramServiceBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<TrainingProgramServiceResource> _localizer;

    public TrainingProgramServiceBrandingProvider(IStringLocalizer<TrainingProgramServiceResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
