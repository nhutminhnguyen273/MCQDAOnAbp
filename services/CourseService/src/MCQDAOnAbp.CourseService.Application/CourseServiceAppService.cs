using System;
using System.Collections.Generic;
using System.Text;
using MCQDAOnAbp.CourseService.Localization;
using Volo.Abp.Application.Services;

namespace MCQDAOnAbp.CourseService;

/* Inherit your application services from this class.
 */
public abstract class CourseServiceAppService : ApplicationService
{
    protected CourseServiceAppService()
    {
        LocalizationResource = typeof(CourseServiceResource);
    }
}
