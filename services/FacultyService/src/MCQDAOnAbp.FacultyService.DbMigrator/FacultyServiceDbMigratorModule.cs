using MCQDAOnAbp.FacultyService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MCQDAOnAbp.FacultyService.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FacultyServiceEntityFrameworkCoreModule),
    typeof(FacultyServiceApplicationContractsModule)
    )]
public class FacultyServiceDbMigratorModule : AbpModule
{
}
