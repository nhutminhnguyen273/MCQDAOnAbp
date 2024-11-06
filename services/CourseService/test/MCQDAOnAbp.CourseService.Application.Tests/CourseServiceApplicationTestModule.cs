using Volo.Abp.Modularity;

namespace MCQDAOnAbp.CourseService;

[DependsOn(
    typeof(CourseServiceApplicationModule),
    typeof(CourseServiceDomainTestModule)
)]
public class CourseServiceApplicationTestModule : AbpModule
{

}
