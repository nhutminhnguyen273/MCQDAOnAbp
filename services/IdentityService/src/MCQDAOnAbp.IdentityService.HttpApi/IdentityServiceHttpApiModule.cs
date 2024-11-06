using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace MCQDAOnAbp.IdentityService;

[DependsOn(
    typeof(IdentityServiceApplicationContractsModule),
    typeof(AbpIdentityHttpApiModule)
    )]
public class IdentityServiceHttpApiModule : AbpModule
{
}
