using Volo.Abp.Modularity;

namespace MCQDAOnAbp.AdministrationService;

public abstract class AdministrationServiceApplicationTestBase<TStartupModule> : AdministrationServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
