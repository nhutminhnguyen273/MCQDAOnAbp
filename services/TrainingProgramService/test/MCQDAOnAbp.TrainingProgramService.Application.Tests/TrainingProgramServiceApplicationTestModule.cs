using Volo.Abp.Modularity;

namespace MCQDAOnAbp.TrainingProgramService;

[DependsOn(
    typeof(TrainingProgramServiceApplicationModule),
    typeof(TrainingProgramServiceDomainTestModule)
)]
public class TrainingProgramServiceApplicationTestModule : AbpModule
{

}
