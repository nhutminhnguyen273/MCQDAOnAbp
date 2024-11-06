using Volo.Abp.Modularity;

namespace MCQDAOnAbp.AdministrationService;

[DependsOn(
    typeof(AdministrationServiceDomainModule),
    typeof(AdministrationServiceTestBaseModule)
)]
public class AdministrationServiceDomainTestModule : AbpModule
{

}
