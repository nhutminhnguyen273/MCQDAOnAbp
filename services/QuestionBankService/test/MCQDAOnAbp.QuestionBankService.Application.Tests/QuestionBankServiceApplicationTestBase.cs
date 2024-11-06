using Volo.Abp.Modularity;

namespace MCQDAOnAbp.QuestionBankService;

public abstract class QuestionBankServiceApplicationTestBase<TStartupModule> : QuestionBankServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
