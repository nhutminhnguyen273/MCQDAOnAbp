using MCQDAOnAbp.QuestionBankService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MCQDAOnAbp.QuestionBankService.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class QuestionBankServiceController : AbpControllerBase
{
    protected QuestionBankServiceController()
    {
        LocalizationResource = typeof(QuestionBankServiceResource);
    }
}
