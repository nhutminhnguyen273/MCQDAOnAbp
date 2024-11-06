using MCQDAOnAbp.AdministrationService.Localization;
using Volo.Abp.Application.Services;

namespace MCQDAOnAbp.AdministrationService;

public abstract class AdministrationServiceAppService : ApplicationService
{
    protected AdministrationServiceAppService()
    {
        LocalizationResource = typeof(AdministrationServiceResource);
    }
}
