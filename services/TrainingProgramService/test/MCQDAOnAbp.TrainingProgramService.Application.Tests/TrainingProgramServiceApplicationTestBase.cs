using Volo.Abp.Modularity;

namespace MCQDAOnAbp.TrainingProgramService;

public abstract class TrainingProgramServiceApplicationTestBase<TStartupModule> : TrainingProgramServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
