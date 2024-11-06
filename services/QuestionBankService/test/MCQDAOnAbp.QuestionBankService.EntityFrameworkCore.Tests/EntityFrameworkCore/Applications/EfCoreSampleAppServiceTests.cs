using MCQDAOnAbp.QuestionBankService.Samples;
using Xunit;

namespace MCQDAOnAbp.QuestionBankService.EntityFrameworkCore.Applications;

[Collection(QuestionBankServiceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<QuestionBankServiceEntityFrameworkCoreTestModule>
{

}
