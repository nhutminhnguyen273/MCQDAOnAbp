using MCQDAOnAbp.FacultyService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MCQDAOnAbp.FacultyService.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class FacultyServiceController : AbpControllerBase
{
    protected FacultyServiceController()
    {
        LocalizationResource = typeof(FacultyServiceResource);
    }
}
