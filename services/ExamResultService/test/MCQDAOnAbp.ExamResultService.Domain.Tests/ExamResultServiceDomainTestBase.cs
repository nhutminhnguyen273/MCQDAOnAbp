using Volo.Abp.Modularity;

namespace MCQDAOnAbp.ExamResultService;

/* Inherit from this class for your domain layer tests. */
public abstract class ExamResultServiceDomainTestBase<TStartupModule> : ExamResultServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
