using Volo.Abp.Modularity;

namespace MCQDAOnAbp.FacultyService;

public abstract class FacultyServiceApplicationTestBase<TStartupModule> : FacultyServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
