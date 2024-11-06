using Volo.Abp.Modularity;

namespace MCQDAOnAbp.ExamResultService;

[DependsOn(
    typeof(ExamResultServiceDomainModule),
    typeof(ExamResultServiceTestBaseModule)
)]
public class ExamResultServiceDomainTestModule : AbpModule
{

}
