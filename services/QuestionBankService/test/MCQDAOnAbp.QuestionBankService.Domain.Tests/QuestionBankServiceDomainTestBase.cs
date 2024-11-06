using Volo.Abp.Modularity;

namespace MCQDAOnAbp.QuestionBankService;

/* Inherit from this class for your domain layer tests. */
public abstract class QuestionBankServiceDomainTestBase<TStartupModule> : QuestionBankServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
