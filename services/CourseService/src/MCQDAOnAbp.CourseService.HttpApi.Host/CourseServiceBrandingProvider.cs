using Microsoft.Extensions.Localization;
using MCQDAOnAbp.CourseService.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MCQDAOnAbp.CourseService;

[Dependency(ReplaceServices = true)]
public class CourseServiceBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<CourseServiceResource> _localizer;

    public CourseServiceBrandingProvider(IStringLocalizer<CourseServiceResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
