using Volo.Abp.Modularity;

namespace MCQDAOnAbp.TrainingProgramService;

/* Inherit from this class for your domain layer tests. */
public abstract class TrainingProgramServiceDomainTestBase<TStartupModule> : TrainingProgramServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
