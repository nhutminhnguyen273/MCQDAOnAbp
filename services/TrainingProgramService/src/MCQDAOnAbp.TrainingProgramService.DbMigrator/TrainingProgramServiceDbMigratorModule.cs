using MCQDAOnAbp.TrainingProgramService.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MCQDAOnAbp.TrainingProgramService.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TrainingProgramServiceEntityFrameworkCoreModule),
    typeof(TrainingProgramServiceApplicationContractsModule)
    )]
public class TrainingProgramServiceDbMigratorModule : AbpModule
{
}
