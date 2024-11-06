using System;
using System.Collections.Generic;
using System.Text;
using MCQDAOnAbp.ExamResultService.Localization;
using Volo.Abp.Application.Services;

namespace MCQDAOnAbp.ExamResultService;

/* Inherit your application services from this class.
 */
public abstract class ExamResultServiceAppService : ApplicationService
{
    protected ExamResultServiceAppService()
    {
        LocalizationResource = typeof(ExamResultServiceResource);
    }
}
