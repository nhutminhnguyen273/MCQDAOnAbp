using MCQDAOnAbp.ExamResultService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MCQDAOnAbp.ExamResultService.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ExamResultServiceEntityFrameworkCoreModule),
    typeof(ExamResultServiceApplicationContractsModule)
    )]
public class ExamResultServiceDbMigratorModule : AbpModule
{
}
