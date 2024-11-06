using MCQDAOnAbp.QuestionBankService.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MCQDAOnAbp.QuestionBankService.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class QuestionBankServicePageModel : AbpPageModel
{
    protected QuestionBankServicePageModel()
    {
        LocalizationResourceType = typeof(QuestionBankServiceResource);
    }
}
