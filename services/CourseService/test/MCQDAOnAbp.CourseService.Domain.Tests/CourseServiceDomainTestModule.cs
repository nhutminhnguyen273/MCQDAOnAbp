using Volo.Abp.Modularity;

namespace MCQDAOnAbp.CourseService;

[DependsOn(
    typeof(CourseServiceDomainModule),
    typeof(CourseServiceTestBaseModule)
)]
public class CourseServiceDomainTestModule : AbpModule
{

}
