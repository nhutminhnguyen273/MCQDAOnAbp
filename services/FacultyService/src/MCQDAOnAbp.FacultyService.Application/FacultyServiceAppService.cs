using System;
using System.Collections.Generic;
using System.Text;
using MCQDAOnAbp.FacultyService.Localization;
using Volo.Abp.Application.Services;

namespace MCQDAOnAbp.FacultyService;

/* Inherit your application services from this class.
 */
public abstract class FacultyServiceAppService : ApplicationService
{
    protected FacultyServiceAppService()
    {
        LocalizationResource = typeof(FacultyServiceResource);
    }
}
