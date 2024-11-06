using Volo.Abp.Modularity;

namespace MCQDAOnAbp.CourseService;

public abstract class CourseServiceApplicationTestBase<TStartupModule> : CourseServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
