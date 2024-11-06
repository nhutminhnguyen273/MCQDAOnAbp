using Microsoft.Extensions.Localization;
using MCQDAOnAbp.IdentityService.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MCQDAOnAbp.IdentityService.Web;

[Dependency(ReplaceServices = true)]
public class IdentityServiceBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<IdentityServiceResource> _localizer;

    public IdentityServiceBrandingProvider(IStringLocalizer<IdentityServiceResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
