using Volo.Abp.Modularity;

namespace MCQDAOnAbp.FacultyService;

/* Inherit from this class for your domain layer tests. */
public abstract class FacultyServiceDomainTestBase<TStartupModule> : FacultyServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
