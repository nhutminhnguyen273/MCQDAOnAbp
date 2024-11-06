using MCQDAOnAbp.QuestionBankService.Samples;
using Xunit;

namespace MCQDAOnAbp.QuestionBankService.EntityFrameworkCore.Domains;

[Collection(QuestionBankServiceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<QuestionBankServiceEntityFrameworkCoreTestModule>
{

}
