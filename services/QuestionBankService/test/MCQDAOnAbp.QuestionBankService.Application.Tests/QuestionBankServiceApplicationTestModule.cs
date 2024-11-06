using Volo.Abp.Modularity;

namespace MCQDAOnAbp.QuestionBankService;

[DependsOn(
    typeof(QuestionBankServiceApplicationModule),
    typeof(QuestionBankServiceDomainTestModule)
)]
public class QuestionBankServiceApplicationTestModule : AbpModule
{

}
