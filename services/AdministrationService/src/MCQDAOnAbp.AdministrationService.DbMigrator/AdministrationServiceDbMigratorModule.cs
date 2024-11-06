using MCQDAOnAbp.AdministrationService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MCQDAOnAbp.AdministrationService.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AdministrationServiceEntityFrameworkCoreModule),
    typeof(AdministrationServiceApplicationContractsModule)
    )]
public class AdministrationServiceDbMigratorModule : AbpModule
{
}
