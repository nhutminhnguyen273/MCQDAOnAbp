using MCQDAOnAbp.CourseService.Samples;
using Xunit;

namespace MCQDAOnAbp.CourseService.EntityFrameworkCore.Domains;

[Collection(CourseServiceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<CourseServiceEntityFrameworkCoreTestModule>
{

}
