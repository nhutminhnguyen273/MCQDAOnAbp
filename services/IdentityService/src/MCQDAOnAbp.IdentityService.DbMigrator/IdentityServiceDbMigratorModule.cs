using MCQDAOnAbp.IdentityService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MCQDAOnAbp.IdentityService.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(IdentityServiceEntityFrameworkCoreModule),
    typeof(IdentityServiceApplicationContractsModule)
    )]
public class IdentityServiceDbMigratorModule : AbpModule
{
}
