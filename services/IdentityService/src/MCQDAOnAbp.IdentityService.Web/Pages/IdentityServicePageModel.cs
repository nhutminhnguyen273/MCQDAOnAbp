using MCQDAOnAbp.IdentityService.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MCQDAOnAbp.IdentityService.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class IdentityServicePageModel : AbpPageModel
{
    protected IdentityServicePageModel()
    {
        LocalizationResourceType = typeof(IdentityServiceResource);
    }
}
