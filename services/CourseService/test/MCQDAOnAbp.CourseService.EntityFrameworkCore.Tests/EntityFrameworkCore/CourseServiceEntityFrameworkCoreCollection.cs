using Xunit;

namespace MCQDAOnAbp.CourseService.EntityFrameworkCore;

[CollectionDefinition(CourseServiceTestConsts.CollectionDefinitionName)]
public class CourseServiceEntityFrameworkCoreCollection : ICollectionFixture<CourseServiceEntityFrameworkCoreFixture>
{

}
