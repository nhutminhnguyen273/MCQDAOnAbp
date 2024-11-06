using Volo.Abp.Modularity;

namespace MCQDAOnAbp.CourseService;

/* Inherit from this class for your domain layer tests. */
public abstract class CourseServiceDomainTestBase<TStartupModule> : CourseServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
