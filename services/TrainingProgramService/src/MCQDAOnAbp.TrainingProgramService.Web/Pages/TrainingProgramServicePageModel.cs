using MCQDAOnAbp.TrainingProgramService.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MCQDAOnAbp.TrainingProgramService.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class TrainingProgramServicePageModel : AbpPageModel
{
    protected TrainingProgramServicePageModel()
    {
        LocalizationResourceType = typeof(TrainingProgramServiceResource);
    }
}
