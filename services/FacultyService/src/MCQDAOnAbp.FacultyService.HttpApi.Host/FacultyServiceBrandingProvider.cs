using Microsoft.Extensions.Localization;
using MCQDAOnAbp.FacultyService.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MCQDAOnAbp.FacultyService;

[Dependency(ReplaceServices = true)]
public class FacultyServiceBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<FacultyServiceResource> _localizer;

    public FacultyServiceBrandingProvider(IStringLocalizer<FacultyServiceResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
