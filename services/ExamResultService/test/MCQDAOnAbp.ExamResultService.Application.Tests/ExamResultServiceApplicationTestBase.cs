using Volo.Abp.Modularity;

namespace MCQDAOnAbp.ExamResultService;

public abstract class ExamResultServiceApplicationTestBase<TStartupModule> : ExamResultServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
