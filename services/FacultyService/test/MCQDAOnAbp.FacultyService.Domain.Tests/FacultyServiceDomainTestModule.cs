using Volo.Abp.Modularity;

namespace MCQDAOnAbp.FacultyService;

[DependsOn(
    typeof(FacultyServiceDomainModule),
    typeof(FacultyServiceTestBaseModule)
)]
public class FacultyServiceDomainTestModule : AbpModule
{

}
