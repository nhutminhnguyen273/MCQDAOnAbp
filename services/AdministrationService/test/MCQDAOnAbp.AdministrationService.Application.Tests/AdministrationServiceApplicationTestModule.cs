using Volo.Abp.Modularity;

namespace MCQDAOnAbp.AdministrationService;

[DependsOn(
    typeof(AdministrationServiceApplicationModule),
    typeof(AdministrationServiceDomainTestModule)
)]
public class AdministrationServiceApplicationTestModule : AbpModule
{

}
