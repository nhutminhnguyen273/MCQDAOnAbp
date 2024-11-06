using MCQDAOnAbp.CourseService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MCQDAOnAbp.CourseService.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CourseServiceEntityFrameworkCoreModule),
    typeof(CourseServiceApplicationContractsModule)
    )]
public class CourseServiceDbMigratorModule : AbpModule
{
}
