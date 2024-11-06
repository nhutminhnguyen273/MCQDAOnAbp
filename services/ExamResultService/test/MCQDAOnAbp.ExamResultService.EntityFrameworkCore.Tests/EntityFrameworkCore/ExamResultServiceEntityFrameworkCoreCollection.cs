using Xunit;

namespace MCQDAOnAbp.ExamResultService.EntityFrameworkCore;

[CollectionDefinition(ExamResultServiceTestConsts.CollectionDefinitionName)]
public class ExamResultServiceEntityFrameworkCoreCollection : ICollectionFixture<ExamResultServiceEntityFrameworkCoreFixture>
{

}
