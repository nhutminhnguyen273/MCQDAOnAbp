using MCQDAOnAbp.CourseService.Samples;
using Xunit;

namespace MCQDAOnAbp.CourseService.EntityFrameworkCore.Applications;

[Collection(CourseServiceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<CourseServiceEntityFrameworkCoreTestModule>
{

}
