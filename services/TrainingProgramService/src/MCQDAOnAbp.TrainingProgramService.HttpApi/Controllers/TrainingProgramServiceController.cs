using MCQDAOnAbp.TrainingProgramService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MCQDAOnAbp.TrainingProgramService.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TrainingProgramServiceController : AbpControllerBase
{
    protected TrainingProgramServiceController()
    {
        LocalizationResource = typeof(TrainingProgramServiceResource);
    }
}
