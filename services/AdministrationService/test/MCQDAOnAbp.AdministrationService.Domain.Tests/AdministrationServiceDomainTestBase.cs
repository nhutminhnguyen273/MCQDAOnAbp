using Volo.Abp.Modularity;

namespace MCQDAOnAbp.AdministrationService;

/* Inherit from this class for your domain layer tests. */
public abstract class AdministrationServiceDomainTestBase<TStartupModule> : AdministrationServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
