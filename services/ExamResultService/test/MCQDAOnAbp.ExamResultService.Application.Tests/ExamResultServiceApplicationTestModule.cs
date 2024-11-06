using Volo.Abp.Modularity;

namespace MCQDAOnAbp.ExamResultService;

[DependsOn(
    typeof(ExamResultServiceApplicationModule),
    typeof(ExamResultServiceDomainTestModule)
)]
public class ExamResultServiceApplicationTestModule : AbpModule
{

}
