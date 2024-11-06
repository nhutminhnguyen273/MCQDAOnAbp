using Volo.Abp.Modularity;

namespace MCQDAOnAbp.FacultyService;

[DependsOn(
    typeof(FacultyServiceApplicationModule),
    typeof(FacultyServiceDomainTestModule)
)]
public class FacultyServiceApplicationTestModule : AbpModule
{

}
