using MCQDAOnAbp.ExamResultService.Samples;
using Xunit;

namespace MCQDAOnAbp.ExamResultService.EntityFrameworkCore.Domains;

[Collection(ExamResultServiceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ExamResultServiceEntityFrameworkCoreTestModule>
{

}
