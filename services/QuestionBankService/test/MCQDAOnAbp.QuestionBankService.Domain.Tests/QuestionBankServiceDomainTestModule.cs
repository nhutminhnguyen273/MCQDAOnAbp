using Volo.Abp.Modularity;

namespace MCQDAOnAbp.QuestionBankService;

[DependsOn(
    typeof(QuestionBankServiceDomainModule),
    typeof(QuestionBankServiceTestBaseModule)
)]
public class QuestionBankServiceDomainTestModule : AbpModule
{

}
