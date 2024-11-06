using System;
using System.Collections.Generic;
using System.Text;
using MCQDAOnAbp.TrainingProgramService.Localization;
using Volo.Abp.Application.Services;

namespace MCQDAOnAbp.TrainingProgramService;

/* Inherit your application services from this class.
 */
public abstract class TrainingProgramServiceAppService : ApplicationService
{
    protected TrainingProgramServiceAppService()
    {
        LocalizationResource = typeof(TrainingProgramServiceResource);
    }
}
