using MCQDAOnAbp.ExamResultService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MCQDAOnAbp.ExamResultService.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ExamResultServiceController : AbpControllerBase
{
    protected ExamResultServiceController()
    {
        LocalizationResource = typeof(ExamResultServiceResource);
    }
}
