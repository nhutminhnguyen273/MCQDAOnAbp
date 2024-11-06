using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;
using Volo.Abp.ObjectExtending;

namespace MCQDAOnAbp.FacultyService;

[DependsOn(
    typeof(FacultyServiceDomainSharedModule),
    typeof(AbpObjectExtendingModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
)]
public class FacultyServiceApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        FacultyServiceDtoExtensions.Configure();
    }
}
