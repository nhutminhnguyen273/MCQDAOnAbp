using MCQDAOnAbp.ExamResultService.Samples;
using Xunit;

namespace MCQDAOnAbp.ExamResultService.EntityFrameworkCore.Applications;

[Collection(ExamResultServiceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ExamResultServiceEntityFrameworkCoreTestModule>
{

}
