using MCQDAOnAbp.ExamResultService.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MCQDAOnAbp.ExamResultService.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ExamResultServicePageModel : AbpPageModel
{
    protected ExamResultServicePageModel()
    {
        LocalizationResourceType = typeof(ExamResultServiceResource);
    }
}
