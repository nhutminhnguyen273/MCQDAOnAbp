using MCQDAOnAbp.CourseService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MCQDAOnAbp.CourseService.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CourseServiceController : AbpControllerBase
{
    protected CourseServiceController()
    {
        LocalizationResource = typeof(CourseServiceResource);
    }
}
