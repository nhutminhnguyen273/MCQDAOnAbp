using Volo.Abp.Modularity;

namespace MCQDAOnAbp.TrainingProgramService;

[DependsOn(
    typeof(TrainingProgramServiceDomainModule),
    typeof(TrainingProgramServiceTestBaseModule)
)]
public class TrainingProgramServiceDomainTestModule : AbpModule
{

}
